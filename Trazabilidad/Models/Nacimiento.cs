using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Trazabilidad.Models
{
    public class Nacimiento
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
        [Display(Name = "Nombre de Ganadero")]
        public string NomGanadero { get; set; }
        public string Zona { get; set; }
        public string Color { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set; }
        [Display(Name = "Fecha de nacimiento")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }
        public int Peso { get; set; }
        public string Enfermedad { get; set; }
        public string Medicamentos { get; set; }
        [Display(Name = "Padre del ganado")]
        public string Padre { get; set; }
        [Display(Name = "Madre del ganado")]
        public string Madre { get; set; }
    }
}