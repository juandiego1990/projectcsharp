using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace wPersonasEntity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Potencia(int iBase, int iExp)
        {
            double dValor = iBase;

            for(int e = iExp; e > 1; e--)
            {
                dValor *= 2;
            }            

            return PartialView(dValor);

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