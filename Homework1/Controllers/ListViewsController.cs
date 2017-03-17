using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Homework1.Models;

namespace Homework1.Controllers
{
    public class ListViewsController : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        // GET: ListViews
        public ActionResult Index()
        {
            return View(db.ListView.ToList());
        }

        // GET: ListViews/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListView listView = db.ListView.Find(id);
            if (listView == null)
            {
                return HttpNotFound();
            }
            return View(listView);
        }

        // GET: ListViews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ListViews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "客戶名稱,聯絡人數量,帳戶數量")] ListView listView)
        {
            if (ModelState.IsValid)
            {
                db.ListView.Add(listView);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(listView);
        }

        // GET: ListViews/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListView listView = db.ListView.Find(id);
            if (listView == null)
            {
                return HttpNotFound();
            }
            return View(listView);
        }

        // POST: ListViews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "客戶名稱,聯絡人數量,帳戶數量")] ListView listView)
        {
            if (ModelState.IsValid)
            {
                db.Entry(listView).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(listView);
        }

        // GET: ListViews/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListView listView = db.ListView.Find(id);
            if (listView == null)
            {
                return HttpNotFound();
            }
            return View(listView);
        }

        // POST: ListViews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ListView listView = db.ListView.Find(id);
            db.ListView.Remove(listView);
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
