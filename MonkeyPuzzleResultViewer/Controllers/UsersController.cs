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
    public class UsersController : Controller
    {
        private monkeypuzzleEntities db = new monkeypuzzleEntities();

        // GET: Users/Edit/5
        public ActionResult Edit()
        {
            if (Session["userID"] == null)
            {
                return RedirectToAction("Login", "Home", null);
            }
            else
            {
                int id = (int)Session["userID"];
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                User user = db.Users.Find(id);
                if (user == null)
                {
                    return HttpNotFound();
                }
                return View(user);
            }
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "userID,Firstname,Surname,userPassword,AccessGroup")] User user)
        {
            if (Session["userID"] == null)
            {
                return RedirectToAction("Login", "Home", null);
            }
            else
            {
                if (ModelState.IsValid)
                {
                    db.Entry(user).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Login", "Home", null);
                }
                return View(user);
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
