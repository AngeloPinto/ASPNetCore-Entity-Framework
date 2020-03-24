using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using CSharpEF.Models;
using CSharpEF.Database;

namespace CSharpEF.Database
{
    public class FuncionarioController : Controller
    {
        private readonly ApplicationDBContext database;

        public FuncionarioController(ApplicationDBContext database)
        {
            this.database = database;
        }

        public IActionResult Index()
        {
            var funcionarios = database.Funcionarios.ToList();
            return View(funcionarios);
        }

        public IActionResult Cadastrar() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Salvar(Funcionario funcionario)
        {
            database.Funcionarios.Add(funcionario);
            database.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}
