using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PesquisaEleitoral.Models;

namespace PesquisaEleitoral.Controllers
{
    public class BairroesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Bairroes
        public ActionResult Index()
        {
            return View(db.Bairroes.ToList());
        }

        // GET: Bairroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bairro bairro = db.Bairroes.Find(id);
            if (bairro == null)
            {
                return HttpNotFound();
            }
            return View(bairro);
        }

        // GET: Bairroes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bairroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BairroId,BairroNome")] Bairro bairro)
        {
            if (ModelState.IsValid)
            {
                db.Bairroes.Add(bairro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bairro);
        }

        // GET: Bairroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bairro bairro = db.Bairroes.Find(id);
            if (bairro == null)
            {
                return HttpNotFound();
            }
            return View(bairro);
        }

        // POST: Bairroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BairroId,BairroNome")] Bairro bairro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bairro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bairro);
        }

        // GET: Bairroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bairro bairro = db.Bairroes.Find(id);
            if (bairro == null)
            {
                return HttpNotFound();
            }
            return View(bairro);
        }

        // POST: Bairroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bairro bairro = db.Bairroes.Find(id);
            db.Bairroes.Remove(bairro);
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
