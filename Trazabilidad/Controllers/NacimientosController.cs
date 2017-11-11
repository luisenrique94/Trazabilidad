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
    //[Authorize]
    public class NacimientosController : Controller
    {
        private TrazabilidadContext db = new TrazabilidadContext();

        // GET: Nacimientos
        public ActionResult Index()
        {
            return View(db.Nacimientos.ToList());
        }

        // GET: Nacimientos/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nacimiento nacimiento = db.Nacimientos.Find(id);
            if (nacimiento == null)
            {
                return HttpNotFound();
            }
            return View(nacimiento);
        }

        // GET: Nacimientos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nacimientos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CodigoId,CodiGanadero,NomGanadero,Zona,Color,Raza,Sexo,FechaNacimiento,Peso,Enfermedad,Medicamentos,Padre,Madre")] Nacimiento nacimiento)
        {
            if (ModelState.IsValid)
            {
                db.Nacimientos.Add(nacimiento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nacimiento);
        }

        // GET: Nacimientos/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nacimiento nacimiento = db.Nacimientos.Find(id);
            if (nacimiento == null)
            {
                return HttpNotFound();
            }
            return View(nacimiento);
        }

        // POST: Nacimientos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CodigoId,CodiGanadero,NomGanadero,Zona,Color,Raza,Sexo,FechaNacimiento,Peso,Enfermedad,Medicamentos,Padre,Madre")] Nacimiento nacimiento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nacimiento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nacimiento);
        }

        // GET: Nacimientos/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nacimiento nacimiento = db.Nacimientos.Find(id);
            if (nacimiento == null)
            {
                return HttpNotFound();
            }
            return View(nacimiento);
        }

        // POST: Nacimientos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Nacimiento nacimiento = db.Nacimientos.Find(id);
            db.Nacimientos.Remove(nacimiento);
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
