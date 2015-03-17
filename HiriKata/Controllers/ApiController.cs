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
        public ActionResult Hello()
        {
            return Json("hello", JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Register(Users obj)
        {
            if(!db.CheckUserName(obj.username)){
                return new EmptyResult();
            }
            db.AddUser(new Users(obj.username, obj.password));
            var newusr = db.FindUser(obj.username);             
            return Json(newusr, JsonRequestBehavior.AllowGet);

        }
    }
}