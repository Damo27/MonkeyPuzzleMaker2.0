//________________________________________Home controller hosting Login, Index, AuthoriseLogin and Logout ActionResult Methods__________
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonkeyPuzzleResultViewer.Models;

namespace MonkeyPuzzleResultViewer.Controllers
{
    public class HomeController : Controller
    {
        private monkeypuzzleEntities db = new monkeypuzzleEntities();

        public ActionResult Index()
        {
            if (Session["userID"] == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }    
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AuthoriseLogin(MonkeyPuzzleResultViewer.Models.User user)
        {
            //__________Following code sets an onject of user class to the user in model whose details match user input_____________
            var userDetails = db.Users.Where(m => m.userID == user.userID && m.userPassword == user.userPassword).FirstOrDefault();
            if (userDetails == null)
            {
                user.ErrorMessage = "Incorrect Username and Password combination";
                return View("Login", user);
            }
            else
            {
                //______following code allows only users into application___________________
                if (userDetails.AccessGroup == 2)
                {
                    Session["userID"] = userDetails.userID;
                    Session["userName"] = userDetails.DisplayName;
                    return View("Index");
                }
                else
                {
                    user.ErrorMessage = "Only students can access this portal.";
                    return View("Login", user);
                }
            }
        }
        //______________Method to Logout of Session__________________
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Home");
        }

    }
}