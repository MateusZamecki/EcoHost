using EcoHost.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoIntegradorMVC.Models.Repositorio;
using System;
using System.Collections.Generic;


namespace Controle_De_Estoque.Controllers
{
    public class LoginController : Controller
    {
        private UsuarioService oUsuarioService = new();
        public IActionResult CreateFuncionario()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateFuncionario(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("CreateFuncionario");
            }
            usuario.DataCadastro = DateTime.UtcNow;
            usuario.EhFuncionario = true;
            oUsuarioService.oRepositorioUsuario.Incluir(usuario);
            return RedirectToAction("CreateFuncionario");
        }
    }
}