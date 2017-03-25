using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practica_Ajax.Models
{
    public class Municipio
    {
        [Key]
        public int municipioID { get; set; }
        public string nombreMunicipio { get; set; }

        public int estadoID { get; set; }

        virtual public Estado estado { get; set; }
    }
}