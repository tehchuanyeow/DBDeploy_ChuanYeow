using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAPI_ChuanYeow.Models;

namespace WebAPI_ChuanYeow.Controllers
{
    public class BookTransactionsController : Controller
    {
        private Database_Deploy_CYEntities db = new Database_Deploy_CYEntities();

        // GET: BookTransactions
        public ActionResult Index()
        {
            return View(db.BookTransactions.ToList());
        }

        // GET: BookTransactions/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookTransaction bookTransaction = db.BookTransactions.Find(id);
            if (bookTransaction == null)
            {
                return HttpNotFound();
            }
            return View(bookTransaction);
        }

        // GET: BookTransactions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookTransactions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BorrowingCard")] BookTransaction bookTransaction)
        {
            if (ModelState.IsValid)
            {
                db.BookTransactions.Add(bookTransaction);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookTransaction);
        }

        // GET: BookTransactions/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookTransaction bookTransaction = db.BookTransactions.Find(id);
            if (bookTransaction == null)
            {
                return HttpNotFound();
            }
            return View(bookTransaction);
        }

        // POST: BookTransactions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BorrowingCard")] BookTransaction bookTransaction)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookTransaction).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookTransaction);
        }

        // GET: BookTransactions/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookTransaction bookTransaction = db.BookTransactions.Find(id);
            if (bookTransaction == null)
            {
                return HttpNotFound();
            }
            return View(bookTransaction);
        }

        // POST: BookTransactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BookTransaction bookTransaction = db.BookTransactions.Find(id);
            db.BookTransactions.Remove(bookTransaction);
            db.SaveChanges();
            return RedirectToAction("Index");
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
