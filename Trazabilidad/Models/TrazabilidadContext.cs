using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Trazabilidad.Models
{
    public class TrazabilidadContext:DbContext
    {
        public TrazabilidadContext() 
            : base("DefaultConnection")
        {

        }
        public DbSet<Nacimiento> Nacimientos { get; set; }
        public DbSet<Destete> Destetes { get; set; }
        public DbSet<Engorde> Engordes { get; set;}
        public DbSet<Sacrificio> Sacrificios { get; set; }
        public DbSet<Venta> Ventas { get; set; }
    }
}
  