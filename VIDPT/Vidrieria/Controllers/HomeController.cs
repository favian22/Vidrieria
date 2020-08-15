using DbBliblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidrieria.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Clients()
        {
            ViewBag.Message = "Your contact page.";
            var clientRepository = new ClientRepository();
            var client = clientRepository.Getclients();

            return View("../Areas/Client/Clients", client);
        }

        public ActionResult Galeria()
        {
            ViewBag.Message = "Galeria de trabajos";

            return View();
        }

        public ActionResult GaleriaVentanas()
        {
            return View("../Areas/Galerias/GaleriaVentanas");
        }
    }
}