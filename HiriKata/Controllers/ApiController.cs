using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HiriKata.Models;

namespace HiriKata.Controllers
{
    public class ApiController : Controller
    {
        private WordDbContext db = new WordDbContext();

        // GET: Api
        public ActionResult Index()
        {
            var query = from Word in db.Words
                        select Word;

            return Json(query.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}