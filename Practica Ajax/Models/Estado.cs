using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practica_Ajax.Models
{
    public class Estado
    {
        [Key]
        public int estadoID { get; set; }
        public string nombreEstado { get; set; }

        public virtual ICollection<Municipio> municipios { get; set; }
    }
}