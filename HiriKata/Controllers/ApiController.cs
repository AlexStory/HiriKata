using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HiriKata.Models;
using HiriKata.Repos;

namespace HiriKata.Controllers
{
    public class ApiController : Controller
    {
        private WordRepository db = new WordRepository();

        // GET: Api
        public ActionResult Index()
        {

            return Json(db.GetWords(), JsonRequestBehavior.AllowGet);
        }
    }

}