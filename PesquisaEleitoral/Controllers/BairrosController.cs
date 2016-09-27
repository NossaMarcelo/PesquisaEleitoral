using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PesquisaEleitoral.Models;
using System.Text.RegularExpressions;
using System.Text;
using System.Globalization;

namespace PesquisaEleitoral.Controllers
{
    [Authorize (Users ="Administrador@gmail.com")]
    public class BairrosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Bairros
        public ActionResult Index()
        {
            return View(db.BairroContext.ToList());
        }

        // GET: Bairros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bairro bairro = db.BairroContext.Find(id);
            if (bairro == null)
            {
                return HttpNotFound();
            }
            return View(bairro);
        }

        // GET: Bairros/Create
        //TESTE
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bairros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BairroId,BairroNome")] Bairro bairro)
        {
            if (ModelState.IsValid)
            {
                /*string nome = bairro.BairroNome;
                nome = RemoveAcentos(nome);
                nome = RemoveEspacos(nome);*/


                db.BairroContext.Add(bairro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bairro);
        }

        private string RemoveEspacos(string text)
        {
            text.TrimStart().TrimEnd();
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            return text = regex.Replace(text, " ");

        }
        public static string RemoveAcentos(string text)
        {
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex(@"/^([a-zA-Zà-úÀ-Ú0-9]|-|_|\s)+$/ ", options);
            return text = regex.Replace(text, "");
        }
        private string RemoveCaracteres(string text)
        {
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex(@"[^\w]+", options);
            return text = regex.Replace(text, "");
        }

        // GET: Bairros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bairro bairro = db.BairroContext.Find(id);
            if (bairro == null)
            {
                return HttpNotFound();
            }
            return View(bairro);
        }

        // POST: Bairros/Edit/5
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

        // GET: Bairros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bairro bairro = db.BairroContext.Find(id);
            if (bairro == null)
            {
                return HttpNotFound();
            }
            return View(bairro);
        }

        // POST: Bairros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bairro bairro = db.BairroContext.Find(id);
            db.BairroContext.Remove(bairro);
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
