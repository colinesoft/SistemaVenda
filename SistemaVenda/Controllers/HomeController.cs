using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVenda.DAL;
using SistemaVenda.Entidades;
using SistemaVenda.Models;

namespace SistemaVenda.Controllers
{
    public class HomeController : Controller
    {
        //Obtem acesso aos dados
        protected AppDbContext _ctx;

        //Construtor
        public HomeController(AppDbContext ctx)
        {
            //Define o context de HomeController
            _ctx = ctx;
        }


        public IActionResult Index()
        {
            //Carrega a Lista de Categorias e passa como parametro para a View do Controller
            IEnumerable<Categorias> categorias = _ctx.Categorias.ToList();
            return View(categorias);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
