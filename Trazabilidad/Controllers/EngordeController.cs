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
    public class EngordeController : Controller
    {
        private TrazabilidadContext db = new TrazabilidadContext();

        // GET: Engorde
        public ActionResult Index()
        {
            return View(db.Engordes.ToList());
        }

        // GET: Engorde/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Engorde engorde = db.Engordes.Find(id);
            if (engorde == null)
            {
                return HttpNotFound();
            }
            return View(engorde);
        }

        // GET: Engorde/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Engorde/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CodigoId,CodiGanadero,Zona,Color,Raza,Sexo,FechaDeEngorde,Peso,Castracion,Enfermedad,Medicamentos")] Engorde engorde)
        {
            if (ModelState.IsValid)
            {
                db.Engordes.Add(engorde);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(engorde);
        }

        // GET: Engorde/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Engorde engorde = db.Engordes.Find(id);
            if (engorde == null)
            {
                return HttpNotFound();
            }
            return View(engorde);
        }

        // POST: Engorde/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CodigoId,CodiGanadero,Zona,Color,Raza,Sexo,FechaDeEngorde,Peso,Castracion,Enfermedad,Medicamentos")] Engorde engorde)
        {
            if (ModelState.IsValid)
            {
                db.Entry(engorde).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(engorde);
        }

        // GET: Engorde/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Engorde engorde = db.Engordes.Find(id);
            if (engorde == null)
            {
                return HttpNotFound();
            }
            return View(engorde);
        }

        // POST: Engorde/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Engorde engorde = db.Engordes.Find(id);
            db.Engordes.Remove(engorde);
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
