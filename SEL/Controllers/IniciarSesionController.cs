using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SEL.DATOS;

namespace SEL.Controllers
{
    public class IniciarSesionController : Controller
    {

        private SELEntities db = new SELEntities();

        // GET: IniciarSesion
        public ActionResult Index()
        {
            if (Session["LOGUEADO"] != null) { return Redirect("/SEL/"); }
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Email, string Password)
        {            
            if (db.PA_INICIAR_SESION(Email, Password).Count() == 0)
            {
                ViewBag.Respuesta = "Acceso no autorizado.";
                return View();
            }
            else
            {
                foreach (var u in db.PA_INICIAR_SESION(Email, Password))
                {
                    Session["LOGUEADO"] = true;
                    Session["ID_USUARIO"] = u.IdUsuarioSEL;
                    Session["NOMBRES_USUARIO"] = u.Nombres + " " + u.Apellidos;
                }
                return Redirect("/SEL/");
            }
        }
    }
}