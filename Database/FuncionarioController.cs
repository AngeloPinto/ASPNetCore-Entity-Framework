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

        public IActionResult Editar(int id)
        {
            //Funcionario funcionario = database.Funcionarios.First(registro => registro.Id == id);
            Funcionario funcionario = database.Funcionarios.Find(id);
            return View("Cadastrar", funcionario);
        }

        public IActionResult Deletar(int id) 
        {
            Funcionario funcionario = database.Funcionarios.Find(id);
            database.Funcionarios.Remove(funcionario);
            database.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Salvar(Funcionario funcionario)
        {
            if (funcionario.Id == 0) {
                // Salva novo
                database.Funcionarios.Add(funcionario);
            } else {
                // Atualizar funcionario
                Funcionario funcionarioDb = database.Funcionarios.Find(funcionario.Id);
                funcionarioDb.Nome    = funcionario.Nome;
                funcionarioDb.Salario = funcionario.Salario;
                funcionarioDb.Cpf     = funcionario.Cpf;
            }

            database.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}
