using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CSharpEF.Models;
using CSharpEF.Database;

namespace CSharpEF.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDBContext database;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ApplicationDBContext database)
        {
            this.database = database;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Teste()
        {
            Categoria c1 = new Categoria();
            Categoria c2 = new Categoria();
            Categoria c3 = new Categoria();
            Categoria c4 = new Categoria();
            
            c1.Nome = "Aluno";
            c2.Nome = "Professor";
            c3.Nome = "Monitor";
            c4.Nome = "Monitor";

            List<Categoria> lstCategoria = new List<Categoria>();

            lstCategoria.Add(c1);
            lstCategoria.Add(c2);
            lstCategoria.Add(c3);
            lstCategoria.Add(c4);

            database.AddRange(lstCategoria);
            database.SaveChanges();

            return Content("Dados salvos");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
