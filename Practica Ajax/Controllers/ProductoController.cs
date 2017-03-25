using Practica_Ajax.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Practica_Ajax.Controllers
{
    public class ProductoController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Producto

        public JsonResult getJsonList()
        {
            var productos = db.productos.ToList();
            return Json(productos, JsonRequestBehavior.AllowGet);
        }

        public class AllowCrossSiteJsonAttribute : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                filterContext.RequestContext.HttpContext.Response.AddHeader("Access-Control-Allow-Origin", "*");
                base.OnActionExecuting(filterContext);
            }
        }
        [HttpPost]
        public JsonResult createProducto(Producto producto)
        {
            var respuesta = new { funciono = false };

            try
            {
                db.productos.Add(producto);
                int registrosModificados = db.SaveChanges();

                //Se logró ejecutar el query, pero, se hicieron cambios?
                if (registrosModificados > 0)
                {
                    respuesta = new { funciono = true };
                }
            }
            catch { }


            return Json(respuesta);
        }

        public JsonResult editarProducto(int id)
        {
            var ProductoEditado = db.productos.Find(id);
            var result = new { id = ProductoEditado.productoID, nombre = ProductoEditado.nombre, precio = ProductoEditado.precio };
            return Json(result, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult eliminarProducto(int id)
        {
            Producto eliminar = db.productos.Find(id);
            var resultado = db.productos.Remove(eliminar);
            db.SaveChanges();
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        //[ActionName("editarProducto")]
        public JsonResult editar(Producto producto)
        {
            //Producto modificar = db.productos.Find(id);
            //var resultado = db.Entry(modificar).State = EntityState.Modified;

            //db.SaveChanges();
            var resultado = db.Entry(producto).State = EntityState.Modified;
            db.SaveChanges();

            return Json(resultado, JsonRequestBehavior.AllowGet);

        }

        public JsonResult detalles(int? id)
        {

            var especificaciones = db.productos.Find(id);
            return Json(especificaciones, JsonRequestBehavior.AllowGet);

        }


        //public JsonResult detallesProducto(int id)
        //{
        //        var detal = db.productos.Find(id);
        //        return Json(detal, JsonRequestBehavior.AllowGet);

        //}


        //public JsonResult detallesProducto()
        //{
        //    var productos = db.productos.ToList();
        //    return Json(productos, JsonRequestBehavior.AllowGet);
        //}

        //[HttpPost]
        //public JsonResult editarProducto([Bind(Include = "precioID,nombre,precio")] Producto productos)
        //{
        //    var resultado = db.Entry(productos).State = EntityState.Modified;
        //    if (ModelState.IsValid)
        //    {
        //        //db.Entry(productos).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return Json(resultado, JsonRequestBehavior.AllowGet);
        //    }
        //    return Json(resultado, JsonRequestBehavior.AllowGet);

        //}



        //[HttpPost]
        //public JsonResult createProducto(Producto producto)
        //{
        //    var respuesta = new { funciono = true };

        //    return Json(respuesta);
        //}
    }
}