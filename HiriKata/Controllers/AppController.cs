using HiriKata.Models;
using HiriKata.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HiriKata.Controllers {
  public class AppController : ApiController {
    private WordRepository db = new WordRepository();

    [Route("app")]
    [HttpGet]
    public List<Word> Index() {

      return db.GetWords();
    }

    [Route("app/categories")]
    [HttpGet]
    public List<String> Categories() {
      return db.GetCategories();
    }

    [Route("app/hirigana/{id}")]
    [HttpGet]
    public List<Word> results(string id) {
      return db.GetByCategory(id);
    }

    [Route("app/katakana/{id}")]
    [HttpGet]
    public List<Word> kata(string id) {
      return db.GetKataByCategory(id);
    }

    [Route("app/games")]
    [HttpPost]
    public HttpResponseMessage PostGame(Game game) {
      db.AddGame(game);
      return new HttpResponseMessage(HttpStatusCode.OK);
    }

    [Route("app/games/{id}")]
    [HttpGet]
    public List<Game> GetGames(int id) {
      return db.GetUsersGames(id);
    }

    [Route("app/perfect/{id}")]
    [HttpGet]
    public List<PerfectGame> GetPerfect(int id) {
      return db.GetPerfectGames(id);
    }

    [Route("app/perfect")]
    [HttpPost]
    public HttpResponseMessage AddPerfect(PerfectGame perfect) {
       db.AddPerfectGame(perfect);
       return new HttpResponseMessage(HttpStatusCode.Accepted);
    }
  }
}
