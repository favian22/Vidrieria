using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidrieria.Models;

namespace Vidrieria.Views.Areas.Client
{
    public class ClientsController : Controller
    {
        // GET: Clients
        public ActionResult Clients()
        {

            return RedirectToAction("Clients");
        }

        public void AddClient(string name)
        {
            var x = new CLIENT();
            
        }
    }
}