using Fiap.Exemplo01.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private static List<Produto> produtos = new List<Produto>();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(produtos);
        }

        [HttpGet] //Manda carregar a view de Cadastrar
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Produto produto)
        {
            produtos.Add(produto);

            ViewBag.mensagem = "Produto cadastrado!";

            return View();
        }
    }
}