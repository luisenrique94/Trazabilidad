using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Trazabilidad.Models
{
    public class Sacrificio
    {
        [Key]
        [Required(ErrorMessage = "EL CAMPO {0} ES REQUERIDO")]
        [StringLength(5, ErrorMessage = "MAXIMO 5 CARACTERES Y MINIMO 3 CARACTERES", MinimumLength = 3)]
        [Display(Name = "Codigo de ganado")]
        public string CodigoId { get; set; }
        [Required(ErrorMessage = "EL CAMPO {0} ES REQUERIDO")]
        [StringLength(8, ErrorMessage = "INGRESAR NUMERO DE DNI", MinimumLength = 8)]
        [Display(Name = "Codigo de Ganadero")]
        public string CodiGanadero { get; set; }
        [Display(Name ="Zona Sacrificio")]
        public string Zona { get; set; }
        public string Color { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set; }
        [Display(Name = "Fecha de Sacrificio")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaDeSacrificio { get; set; }
        [Display (Name="Peso De Sacrificio")]
        public int PesoSacrificio { get; set; }
        [Required(ErrorMessage ="CAMPO{{0} REQUERIDO")]
        [StringLength(6,ErrorMessage ="Maximo 6 caracteres")]
        [Display(Name ="Codigo Carcasa Derecha")]
        public  string CodigoDerecho{ get; set;}
        [Required(ErrorMessage = "CAMPO{0} REQUERIDO")]
        [StringLength(6, ErrorMessage = "Maximo 6 caracteres")]
        [Display(Name = "Codigo Carcasa Izquierda")]
        public string CodigoIzquiero { get; set; }
        [Display(Name ="Peso Carcasa Derecha")]
        public int PesoDerecho { get; set; }
        [Display(Name ="Peso Carcasa Izquierda")]
        public int PesoIzquierdo { get; set; }
        [Display(Name ="Enfermedad De Viceras")]
        public string Enfermedad { get; set; }
        
       
    }
}