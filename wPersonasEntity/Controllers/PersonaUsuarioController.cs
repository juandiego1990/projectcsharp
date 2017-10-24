using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wPersonasEntity.Models;

namespace wPersonasEntity.Controllers
{
    public class PersonaUsuarioController : Controller
    {
        // GET: PersonaUsuario
        public ActionResult CreatePU()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatePU(PersonaUsuario model)
        {


            return RedirectToAction("Index", "personas");
        }

    }
}