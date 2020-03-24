using System;
using CSharpEF.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSharpEF.Database
{
    public class FuncionarioController : Controller
    {
        public IActionResult Cadastrar() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Salvar(Funcionario funcionario)
        {
            return Content(funcionario.Nome.ToString() + " " + funcionario.Salario + " " + funcionario.Cpf);
        }
    }

}
