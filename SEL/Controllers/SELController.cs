using SEL.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SEL.Controllers
{
    public class SELController : Controller
    {

        private SELEntities db = new SELEntities();

        // GET: SEL
        public ActionResult Index()
        {
            if (Session["LOGUEADO"] == null) { return Redirect("/IniciarSesion/"); }
            return View();
        }

        public ActionResult Consultar()
        {
            if (Session["LOGUEADO"] == null) { return Redirect("/IniciarSesion/"); }

            ViewBag.solicitudes = db.PA_CONSULTAR_SOLICITUDES_SERVICIO_POR_ID_USUARIO(int.Parse(Session["ID_USUARIO"].ToString()));
            return View();
        }

        public ActionResult CrearSolicitud(string FechaServicio, string HoraServicio, string FechaCita, string HoraCita, string FechaRecojida, string HoraRecogida, string Origen, string Destino)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ViewBag.RespuestaCorrecta = "Solicitud Registrada.";
                    db.PA_SOLICITAR_SERVICIO(int.Parse(Session["ID_USUARIO"].ToString()), FechaServicio, HoraServicio, FechaCita, HoraCita, FechaRecojida, HoraRecogida, Origen, Destino);
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(ex.Source);
            }
        }

        public ActionResult CerrarSesion()
        {
            Session["LOGUEADO"] = null;
            Session["ID_USUARIO"] = null;
            Session["NOMBRES_USUARIO"] = null;

            return Redirect("/IniciarSesion/");
        }

    }
}