using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class ClienteController : Controller
    {
        //GET: Cliente/Cliente
        public ActionResult Cliente()
        {
            var cliente = new Cliente();
            cliente.id = 1;
            cliente.nombre = "David Ernesto Cruz Velasquez";
            cliente.edad = 23;
            cliente.telefono = "7777-7777";
            cliente.DUI = "12345678-9";
            cliente.direccion = "Mi casa";

            return View(cliente);
        }
    }
}