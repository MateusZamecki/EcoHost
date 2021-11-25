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

        public IActionResult Principal()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Principal(Usuario usuarioLogin)
        {
            var usuarios = oUsuarioService.oRepositorioUsuario.SelecionarTodos();
            var usuarioEmail = usuarios.Find(usuario => usuario.Email.Equals(usuarioLogin.Email) && usuario.Senha.Equals(usuarioLogin.Senha));
            if (usuarioEmail != null)
            {
                if (usuarioEmail.EhFuncionario)
                {
                    return RedirectToAction("Principal", "FuncionarioProduto");
                }
                return RedirectToAction("Principal", "Cliente");
            }
            else
            {
                return RedirectToAction("Principal");
            }
        }
    }
}