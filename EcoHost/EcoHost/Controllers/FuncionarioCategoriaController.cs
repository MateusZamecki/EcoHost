using EcoHost.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoIntegradorMVC.Models.Repositorio;
using System.Collections.Generic;

namespace Controle_De_Estoque.Controllers
{
    public class FuncionarioCategoriaController : Controller
    {
        private CategoriaService oCategoriaService = new();
        public IActionResult Principal()
        {
            List<Categoria> categorias = oCategoriaService.oRepositorioCategoria.SelecionarTodos();
            return View(categorias);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Categoria categoria)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Create");
            }

            oCategoriaService.oRepositorioCategoria.Incluir(categoria);
            return RedirectToAction("Create");
        }

        public IActionResult Delete(int id)
        {
            oCategoriaService.oRepositorioCategoria.Excluir(id);
            return RedirectToAction("Principal");
        }

        public IActionResult Details(int id)
        {
            var categoria = oCategoriaService.oRepositorioCategoria.SelecionarPorId(id);
            return View(categoria);
        }
        public IActionResult Edit(int id)
        {            
            var categoria = oCategoriaService.oRepositorioCategoria.SelecionarPorId(id);
            return View(categoria);
        }
        [HttpPost]
        public IActionResult Edit(Categoria categoria)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Edit");
            }
            oCategoriaService.oRepositorioCategoria.Alterar(categoria);
            return RedirectToAction("Principal");
        }
    }
}