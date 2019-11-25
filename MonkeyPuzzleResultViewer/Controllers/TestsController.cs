//_______________________________________Tests Controller hosts Index, TakeTest and [Http Post] ActionResult methods___________________
//_____________________________________Please note the functionality in this controller is incomplete and awaiting changes_____________
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
    public class TestsController : Controller
    {
        private monkeypuzzleEntities db = new monkeypuzzleEntities();

        // GET: Tests returns list of all tests
        public ActionResult Index()
        {
            if (Session["userID"] == null)
            {
                return RedirectToAction("Login", "Home", null);
            }
            else
            {
                int id = (int)Session["userID"];
                var testsTakenIDs = db.Marks.Where(m => m.userID == id).Select(m => m.testID);
                var testsTaken = from test in db.Tests where testsTakenIDs.Contains(test.testID) select test;
                var testsNotTaken = db.Tests.Except(testsTaken);

                return View(testsNotTaken.ToList());
            }
        }

        // GET: Tests/TakeTest displays entire test as radiobutton mcq's
        public ActionResult TakeTest(int id)
        {
            if (Session["userID"] == null)
            {
                return RedirectToAction("Login", "Home", null);
            }
            else
            {
                List<Question> questions = db.Questions.Where(m => m.testID == id).ToList();
                return View(questions);
            }
        }

        // POST: Tests/TakeTests handles the submission of a test.
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TakeTest(ICollection<Question> model)
        {
            if (Session["userID"] == null)
            {
                return RedirectToAction("Login", "Home", null);
            }
            else
            {
                int count = 0;
                Mark mark = new Mark();

                foreach (var item in model)
                {
                    if (item.CorrectAnswer == item.SelectedAnswer)
                    {
                        count++;
                    }
                }
                mark.Mark1 = count;
                var lastMark = db.Marks.ToList().LastOrDefault();
                mark.markID = lastMark.markID + 1;
                mark.testID = model.ToList().FirstOrDefault().testID;
                mark.Percentage = (100 * count) / model.Count;
                mark.userID = (int)Session["userID"];
                db.Marks.Add(mark);
                db.SaveChanges();
                return RedirectToAction("Index", "Marks", null);
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
