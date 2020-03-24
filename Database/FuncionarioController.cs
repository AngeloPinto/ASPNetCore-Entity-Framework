using System;
using CSharpEF.Models;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Cadastrar() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Salvar(Funcionario funcionario)
        {
            database.Funcionarios.Add(funcionario);
            database.SaveChanges();
            return Content("Funcionário Salvo com Sucesso!!!");
        }
    }

}
