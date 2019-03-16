using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace productoBackend.Models
{
    public class Producto
    {

        [Key]
        public int ProductID { get; set; }

        [Required]
        [Display(Name = "Nombre del Producto")]
        public string Nombre { get; set; }

        public double Precio { get; set; }


    }
}