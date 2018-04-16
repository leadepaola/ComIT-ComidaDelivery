using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPedidos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DatabasePedidosOnlineEntities hola = new DatabasePedidosOnlineEntities();

                System.Collections.Generic.List<Comercio2> i = hola.Comercio2.Where(x=>x.Id==1).ToList();
                System.Collections.Generic.List<Comercio2> i2 = hola.Comercio2.Where(x => x.Id == 2).ToList();



            ViewBag.comercios = i;
            ViewBag.comercios2 = i2;


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";


            return View();
        }
    }
}