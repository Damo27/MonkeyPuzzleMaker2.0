//__________________________________Marks controller hosts Index, PickMemo and Memo ActionResult methods____________________________
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MonkeyPuzzleResultViewer.Models;

namespace MonkeyPuzzleResultViewer.Controllers
{
    public class MarksController : Controller
    {
        private monkeypuzzleEntities db = new monkeypuzzleEntities();

        // GET: Marks Returns a view which displays a list of marks specific to session user
        public ActionResult Index()
        {
            if (Session["userID"] == null)
            {
                return RedirectToAction("Login", "Home", null);
            }
            else
            {
                int id = (int)Session["userID"];
                var marks = db.Marks.Where(m => m.userID == id).Include(m => m.Test).Include(m => m.User).Include(m => m.Test.Questions);
                return View(marks.ToList());
            }
        }

        //GET: PickMemo Returns a view with a list of tests the session user has taken in order to select a memo to view
        public ActionResult PickMemo()
        {
            if (Session["userID"] == null)
            {
                return RedirectToAction("Login", "Home", null);
            }
            else
            {
                int id = (int)Session["userID"];
                var marks = db.Marks.Where(m => m.userID == id).Include(m => m.Test).Include(m => m.User).Include(m => m.Test.Questions);
                return View(marks.ToList());
            }
        }

        // GET: Marks/Memo returns a view which displays the memo of the chosen test
        public ActionResult Memo(int id)
        {
            if (Session["userID"] == null)
            {
                return RedirectToAction("Login", "Home", null);
            }
            else
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                ViewBag.TestName = db.Tests.Where(m => m.testID == id).FirstOrDefault().TestName;
                var questions = db.Questions.Where(m => m.testID == id).Include(m => m.Test);
                if (questions == null)
                {
                    return HttpNotFound();
                }
                return View(questions.ToList());
            }    
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
