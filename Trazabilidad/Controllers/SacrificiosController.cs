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
    public class SacrificiosController : Controller
    {
        private TrazabilidadContext db = new TrazabilidadContext();

        // GET: Sacrificios
        public ActionResult Index()
        {
            return View(db.Sacrificios.ToList());
        }

        // GET: Sacrificios/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sacrificio sacrificio = db.Sacrificios.Find(id);
            if (sacrificio == null)
            {
                return HttpNotFound();
            }
            return View(sacrificio);
        }

        // GET: Sacrificios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sacrificios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CodigoId,CodiGanadero,Zona,Color,Raza,Sexo,FechaDeSacrificio,PesoSacrificio,CodigoDerecho,CodigoIzquiero,PesoDerecho,PesoIzquierdo,Enfermedad")] Sacrificio sacrificio)
        {
            if (ModelState.IsValid)
            {
                db.Sacrificios.Add(sacrificio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sacrificio);
        }

        // GET: Sacrificios/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sacrificio sacrificio = db.Sacrificios.Find(id);
            if (sacrificio == null)
            {
                return HttpNotFound();
            }
            return View(sacrificio);
        }

        // POST: Sacrificios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CodigoId,CodiGanadero,Zona,Color,Raza,Sexo,FechaDeSacrificio,PesoSacrificio,CodigoDerecho,CodigoIzquiero,PesoDerecho,PesoIzquierdo,Enfermedad")] Sacrificio sacrificio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sacrificio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sacrificio);
        }

        // GET: Sacrificios/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sacrificio sacrificio = db.Sacrificios.Find(id);
            if (sacrificio == null)
            {
                return HttpNotFound();
            }
            return View(sacrificio);
        }

        // POST: Sacrificios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Sacrificio sacrificio = db.Sacrificios.Find(id);
            db.Sacrificios.Remove(sacrificio);
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
