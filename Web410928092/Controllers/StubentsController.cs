using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web410928092.Models;

namespace Web410928092.Controllers
{
    public class StubentsController : Controller
    {
        private db410928092Entities db = new db410928092Entities();

        // GET: Stubents
        public ActionResult Index()
        {
            return View(db.Stubent.ToList());
        }

        // GET: Stubents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stubent stubent = db.Stubent.Find(id);
            if (stubent == null)
            {
                return HttpNotFound();
            }
            return View(stubent);
        }

        // GET: Stubents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stubents/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Number,Email,IsActive")] Stubent stubent)
        {
            if (ModelState.IsValid)
            {
                db.Stubent.Add(stubent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stubent);
        }

        // GET: Stubents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stubent stubent = db.Stubent.Find(id);
            if (stubent == null)
            {
                return HttpNotFound();
            }
            return View(stubent);
        }

        // POST: Stubents/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Number,Email")] Stubent stubent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stubent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stubent);
        }

        // GET: Stubents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stubent stubent = db.Stubent.Find(id);
            if (stubent == null)
            {
                return HttpNotFound();
            }
            return View(stubent);
        }

        // POST: Stubents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stubent stubent = db.Stubent.Find(id);
            db.Stubent.Remove(stubent);
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
