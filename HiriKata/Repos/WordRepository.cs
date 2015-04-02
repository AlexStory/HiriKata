using HiriKata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Newtonsoft.Json.Linq;

namespace HiriKata.Repos
{
    public class WordRepository
    {
        private WordDbContext _dbContext;

        public WordRepository()
        {
            _dbContext = new WordDbContext();
            _dbContext.Words.Load();
            _dbContext.Users.Load();
            
        }

        public bool CheckUserName(string username)
        {
            var query = from Users in _dbContext.Users
                        where Users.username == username
                        select Users;
            Users result = query.FirstOrDefault<Users>();
            return result == null;  
        }
        

        public List<Word> GetWords()
        {
            var query = from Word in _dbContext.Words
                        select Word;
            return query.ToList<Word>();
        }

        internal void AddUser(Users users)
        {
            _dbContext.Users.Add(users);
            _dbContext.SaveChanges();
        }

        internal Users FindUser(string p)
        {
            var query = from Users in _dbContext.Users
                        where Users.username == p
                        select Users;
            return query.First<Users>();
        }

        internal Dictionary<string, string> CheckLogin(string username, string password)
        {
            var query = from Users in _dbContext.Users
                        where Users.username == username
                        select Users;
            Users result = query.FirstOrDefault<Users>();
            if (result.checkPass(password))
            {
                return GetUser(username);
            }
            else throw new ArgumentException();
        }

        public Dictionary<string, string> GetUser(string p)
        {
            var query = from Users in _dbContext.Users
                        where Users.username == p
                        select Users.username;
            var query2 = from Users in _dbContext.Users
                         where Users.username == p
                         select Users.ID;


            Dictionary<string, string> user = new Dictionary<string, string>();
            user.Add("username", query.First<string>());
            user.Add("ID", query2.First<int>().ToString());
            
            return user;
        }

        public List<string> GetCategories() {
          var query = from Word in _dbContext.Words
                      select Word.Category;
          return query.Distinct<string>().ToList<string>();
        }

        public List<string> GetSections() {
          var query = from Word in _dbContext.Words
                      select Word.Section;
          return query.Distinct<string>().ToList<string>();
        }

        public List<Word> GetByCategory(string id) {
          var query = from Word in _dbContext.Words
                      where Word.Category == id &&
                            Word.Section == "Hirigana"
                      select Word;
          return query.ToList<Word>();
        }

        internal void AddGame(Game game) {
          _dbContext.Games.Add(game);
          _dbContext.SaveChanges();
        }

        internal List<Game> GetUsersGames(int id) {
          var query = from Game in _dbContext.Games
                      where Game.UserID == id
                      select Game;
          return query.ToList<Game>();
        }

        internal List<Word> GetKataByCategory(string id) {
          var query = from Word in _dbContext.Words
                      where Word.Category == id &&
                            Word.Section == "Katakana"
                      select Word;
          return query.ToList<Word>();
        }

        internal List<PerfectGame> GetPerfectGames(int id) {
          var query = from PerfectGame in _dbContext.PerfectGames
                      where PerfectGame.UserID == id
                      select PerfectGame;
          return query.ToList<PerfectGame>();
        }

        internal void AddPerfectGame(PerfectGame perfect) {
          var query = from PerfectGame in _dbContext.PerfectGames
                      where PerfectGame.UserID == perfect.UserID &&
                        PerfectGame.Section == perfect.Section &&
                        PerfectGame.Category == perfect.Category
                      select PerfectGame;
          var result = query.FirstOrDefault<PerfectGame>();
          if (result == null) {
            _dbContext.PerfectGames.Add(perfect);
              _dbContext.SaveChanges();
          }


        }

        public List<GameResult> FindDistinct(int id) {
          var categories = GetCategories();
          var sections = GetSections();
          List<GameResult> results = new List<GameResult>();

          foreach (string section in sections) {
            foreach (string category in categories) {
              var query = from game in _dbContext.Games
                          where game.UserID == id &&
                          game.Category == category &&
                          game.Section == section
                          select game;
              var Q = query.ToList<Game>();
              var temp = new GameResult();
              temp.Games = Q.Count();
              temp.Category = category;
              temp.Section = section;
              temp.PerfectGames = 0;
              foreach (Game game in Q) {
                if (game.Possible == game.Correct) { temp.PerfectGames++; }
              }
              results.Add(temp);
            }
          }

          return results;

        } 
    }


}