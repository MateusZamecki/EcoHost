using EcoHost.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoIntegradorMVC.Models.Repositorio;
using System;
using System.Collections.Generic;


namespace Controle_De_Estoque.Controllers
{
    public class RegistraContaController : Controller
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
            oUsuarioService.oRepositorioUsuario.Incluir(usuario);
            return RedirectToAction("CreateFuncionario");
        }

        public IActionResult CreateCliente()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCliente(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("CreateCliente");
            }
            usuario.EhFuncionario = false;
            oUsuarioService.oRepositorioUsuario.Incluir(usuario);
            return RedirectToAction("CreateCliente");
        }
    }
}