using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Trazabilidad.Models;

namespace Trazabilidad.Controllers
{
    public class DestetesController : Controller
    {
        private TrazabilidadContext db = new TrazabilidadContext();

        // GET: Destetes
        public ActionResult Index()
        {
            return View(db.Destetes.ToList());
        }

        // GET: Destetes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Destete destete = db.Destetes.Find(id);
            if (destete == null)
            {
                return HttpNotFound();
            }
            return View(destete);
        }

        // GET: Destetes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Destetes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CodigoId,CodiGanadero,Zona,Color,Raza,Sexo,FechaDestete,Peso,Enfermedad,Medicamentos")] Destete destete)
        {
            if (ModelState.IsValid)
            {
                db.Destetes.Add(destete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(destete);
        }

        // GET: Destetes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Destete destete = db.Destetes.Find(id);
            if (destete == null)
            {
                return HttpNotFound();
            }
            return View(destete);
        }

        // POST: Destetes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CodigoId,CodiGanadero,Zona,Color,Raza,Sexo,FechaDestete,Peso,Enfermedad,Medicamentos")] Destete destete)
        {
            if (ModelState.IsValid)
            {
                db.Entry(destete).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(destete);
        }

        // GET: Destetes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Destete destete = db.Destetes.Find(id);
            if (destete == null)
            {
                return HttpNotFound();
            }
            return View(destete);
        }

        // POST: Destetes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Destete destete = db.Destetes.Find(id);
            db.Destetes.Remove(destete);
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
