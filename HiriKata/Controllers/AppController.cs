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
  }
}
