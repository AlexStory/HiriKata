using HiriKata.Models;
using HiriKata.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HiriKata.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        private WordRepository db = new WordRepository();
        
        public ActionResult Index(string username, string password)
        {
             Users obj = new Users(username, password);

             if (!db.CheckUserName(obj.username.ToString()))
             {
                 return new EmptyResult();
             }
            db.AddUser(obj);
            var newusr = db.FindUser(obj.username.ToString());
            return Json(newusr, JsonRequestBehavior.AllowGet);
            
        }

        public ActionResult Login(string username, string password)
        {
            Users obj = new Users(username, password);
            try
            {
              Users  result = db.CheckLogin(username, password);
              return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return new EmptyResult();
            }
        }

    }
}