using EcoHost.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoIntegradorMVC.Models.Repositorio;
using System.Collections.Generic;

namespace Controle_De_Estoque.Controllers
{
    public class FuncionarioProdutoController : Controller
    {
        private ProdutoService oProdutoService = new();
        private CategoriaService oCategoriaService = new();
        private FornecedorService oFornecedorService = new();
        public IActionResult Principal()
        {
            List<Produto> produtos = oProdutoService.oRepositorioProduto.SelecionarTodos();
            foreach (var produto in produtos) 
            {
                var categoria = oCategoriaService.oRepositorioCategoria.SelecionarPorId(produto.CategoriaId);//Rever conceitos
                var fornecedor = oFornecedorService.oRepositorioFornecedor.SelecionarPorId(produto.FornecedorId);
                produto.AdicionarCategoria(categoria);
                produto.AdicionarFornecedor(fornecedor);
            }
            return View(produtos);
        }
        public IActionResult Create()
        {
            ViewBag.CategoriaId = PreencherSelectListComCategorias();
            ViewBag.FornecedorId = PreencherSelectListComFornecedores();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Produto produto)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Create");
            }
            produto.CustoCompra /= 100;
            produto.ValorVenda /= 100;
            oProdutoService.oRepositorioProduto.Incluir(produto);
            return RedirectToAction("Create");
        }

        public IActionResult Delete(int id)
        {
            oProdutoService.oRepositorioProduto.Excluir(id);
            return RedirectToAction("Principal");
        }

        public IActionResult Details(int id)
        {
            var produto = oProdutoService.oRepositorioProduto.SelecionarPorId(id);
            var categoria = oCategoriaService.oRepositorioCategoria.SelecionarPorId(produto.CategoriaId);
            var fornecedor = oFornecedorService.oRepositorioFornecedor.SelecionarPorId(produto.CategoriaId);
            produto.AdicionarCategoria(categoria);
            produto.AdicionarFornecedor(fornecedor);
            return View(produto);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.CategoriaId = PreencherSelectListComCategorias();
            ViewBag.FornecedorId = PreencherSelectListComFornecedores();
            var produto = oProdutoService.oRepositorioProduto.SelecionarPorId(id);
            var categoria = oCategoriaService.oRepositorioCategoria.SelecionarPorId(produto.CategoriaId);
            var fornecedor = oFornecedorService.oRepositorioFornecedor.SelecionarPorId(produto.CategoriaId);
            produto.AdicionarCategoria(categoria);
            produto.AdicionarFornecedor(fornecedor);
            return View(produto);
        }
        [HttpPost]
        public IActionResult Edit(Produto produto)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Edit");
            }
            produto.CustoCompra /= 100;
            produto.ValorVenda /= 100;
            oProdutoService.oRepositorioProduto.Alterar(produto);
            return RedirectToAction("Principal");
        }

        public SelectList PreencherSelectListComCategorias()
        {
            var categorias = oCategoriaService.oRepositorioCategoria.SelecionarTodos();
            return new SelectList(categorias, "Id", "Nome");
        }
        public SelectList PreencherSelectListComFornecedores()
        {
            var fornecedores = oFornecedorService.oRepositorioFornecedor.SelecionarTodos();
            return new SelectList(fornecedores, "Id", "Nome");
        }
    }
}