using Practica_Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica_Ajax.Controllers
{
    public class MunicipioController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Municipio
        public JsonResult getMunicipios(int id)
        {
            var algo = db.municipios.Where(a => a.estadoID == id);
            var Municipios = from este in algo
                             select new { estadoID = este.municipioID, nombre = este.nombreMunicipio };
            return Json(Municipios, JsonRequestBehavior.AllowGet);
        }
    }
}