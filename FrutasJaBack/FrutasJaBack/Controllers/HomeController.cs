using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FrutasJaBack.Models;
using FrutasJaBack.Repositories.Contracts;

namespace FrutasJaBack.Controllers
{
    public class HomeController : Controller
    {

        private IClienteRepository _repositoryCliente;

        public HomeController(IClienteRepository repositoryCliente)
        {
            _repositoryCliente = repositoryCliente;
        }



        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public IActionResult Frutas()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Verduras()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Legumes()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Whybuy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Usuario cliente)
        {
           

                /* Salvar - EF Core, SQLConnection*/
                _repositoryCliente.Cadastrar(cliente);

                TempData["MSG_S"] = "Cadastro realizado com sucesso!";
                //TODO - Implementar redirecionamentos diferentes (Painel, Carrinho de Compras, etc).

                return RedirectToAction(nameof(Cadastrar));
                //TODO - Grava no Banco
        
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
