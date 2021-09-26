using EcoHost.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoIntegradorMVC.Models.Repositorio;
using System.Collections.Generic;

namespace Controle_De_Estoque.Controllers
{
    public class FuncionarioFornecedorController : Controller
    {
        private FornecedorService oFornecedorService = new();
        public IActionResult Principal()
        {
            List<Fornecedor> fornecedores = oFornecedorService.oRepositorioFornecedor.SelecionarTodos();
            return View(fornecedores);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Fornecedor fornecedor)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Create");
            }

            oFornecedorService.oRepositorioFornecedor.Incluir(fornecedor);
            return RedirectToAction("Create");
        }

        public IActionResult Delete(int id)
        {
            oFornecedorService.oRepositorioFornecedor.Excluir(id);
            return RedirectToAction("Principal");
        }

        public IActionResult Details(int id)
        {
            var fornecedor = oFornecedorService.oRepositorioFornecedor.SelecionarPorId(id);
            return View(fornecedor);
        }
        public IActionResult Edit(int id)
        {            
            var fornecedor = oFornecedorService.oRepositorioFornecedor.SelecionarPorId(id);
            return View(fornecedor);
        }
        [HttpPost]
        public IActionResult Edit(Fornecedor fornecedor)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Edit");
            }
            oFornecedorService.oRepositorioFornecedor.Alterar(fornecedor);
            return RedirectToAction("Principal");
        }
    }
}