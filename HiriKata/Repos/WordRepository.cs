using HiriKata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

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

        public IEnumerable<Word> GetWords()
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
    }


}