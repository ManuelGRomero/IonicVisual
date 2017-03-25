using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practica_Ajax.Models
{
    public class Producto
    {
        [Key]
        public int productoID { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public string proveedor { get; set; }
        public string peso { get; set; }
        public string descripcion { get; set; }
        public int stock { get; set; }
    }
}