using Fiap.Exemplo01.MVC.Web.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Web.Controllers
{
    public class ClienteController : Controller
    {
        private static List<Cliente> _clientes = new List<Cliente>();
        
        public ActionResult Listar()
        {
            return View(_clientes);
        }
        
        // GET: Cliente
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Cliente cliente)
        {
            _clientes.Add(cliente);
            TempData["mensagem"] = "Cliente cadastrado com sucesso.";
            return RedirectToAction("Cadastrar");
        }
    }
}