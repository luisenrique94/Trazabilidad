using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Trazabilidad.Models
{
    public class Venta
    {
        [Key]
        [Required(ErrorMessage = "EL CAMPO {0} ES REQUERIDO")]
        [StringLength(5, ErrorMessage = "MAXIMO 5 CARACTERES Y MINIMO 3 CARACTERES", MinimumLength = 3)]
        [Display(Name = "Codigo de Cliente")]
        public string ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Empresa { get; set;}
        [Required(ErrorMessage = "EL CAMPO {0} ES REQUERIDO")]
        [StringLength(11, ErrorMessage = "INGRESR NUMERO DE RUC", MinimumLength = 11)]
        [Display(Name = "Numero De Ruc")]
        public string Ruc { get; set; }
        //PRODUCTO
        [Display(Name ="Peso(Kg)")]
        public string Peso { get; set; }
        [Display(Name ="Tipo De Corte")]
        public string TipoDeCorte { get; set; }
        [Display(Name = "Codigo De Barra Paquete")]
        public string CodBarra{ get; set; }
        [Display(Name = "Codigo De Barra Carcasa")]
        public string CodBarraCarcasa { get; set; }
        [Display(Name = "Fecha de Venta")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaDeVenta { get; set; }
        
        
       
    }
}