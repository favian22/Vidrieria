using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DbBliblioteca
{
    public class ClientRepository
    {
        private ContextBlibliotecaVirtual _context;

        public ClientRepository()
        {
            _context = new ContextBlibliotecaVirtual();
        }


        public List<CLIENT> Getclients()
        {
            List<CLIENT> listClients = _context.CLIENT.ToList();

            return listClients;
        }
    }
}