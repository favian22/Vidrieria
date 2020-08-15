using DbBliblioteca;
using System.Web.Mvc;

namespace Vidrieria.Views.Areas.Client
{
    public class ClientsController : Controller
    {
        // GET: Clients
        public ActionResult Clients()
        {
            var clientRepository = new ClientRepository();
            var client = clientRepository.Getclients();

            return RedirectToAction("Clients");
        }

        public void AddClient(string name)
        {
            
            
        }
    }
}