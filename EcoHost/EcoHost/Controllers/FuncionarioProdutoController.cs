using EcoHost.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoIntegradorMVC.Ajudantes;
using ProjetoIntegradorMVC.Models.Repositorio;
using System.Collections.Generic;

namespace Controle_De_Estoque.Controllers
{
    public class FuncionarioProdutoController : Controller
    {
        private ProdutoService oProdutoService = new();
        private CategoriaService oCategoriaService = new();
        private FornecedorService oFornecedorService = new();
        private ConsultaPorId consulta = new();
        public IActionResult Principal()
        {
            List<Produto> produtos = oProdutoService.oRepositorioProduto.SelecionarTodos();
            foreach (var produto in produtos) 
            {
                var categoria = consulta.BuscarCategoriaPorId(produto.CategoriaId);
                var fornecedor = consulta.BuscarFornecedorPorId(produto.FornecedorId);
                produto.AdicionarCategoria();
                produto.AdicionarFornecedor();
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
            produto.DividirCustoDaCompraPorCem();
            produto.DividirValorVendaPorCem();
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
            var produto = consulta.BuscarProdutoPorId(id);
            var categoria = consulta.BuscarCategoriaPorId(produto.CategoriaId);
            var fornecedor = consulta.BuscarFornecedorPorId(produto.CategoriaId);
            produto.AdicionarCategoria();
            produto.AdicionarFornecedor();
            return View(produto);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.CategoriaId = PreencherSelectListComCategorias();
            ViewBag.FornecedorId = PreencherSelectListComFornecedores();
            var produto = consulta.BuscarProdutoPorId(id);
            var categoria = consulta.BuscarCategoriaPorId(produto.CategoriaId);
            var fornecedor = consulta.BuscarFornecedorPorId(produto.CategoriaId);
            produto.AdicionarCategoria();
            produto.AdicionarFornecedor();
            return View(produto);
        }
        [HttpPost]
        public IActionResult Edit(Produto produto)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Edit");
            }
            produto.DividirCustoDaCompraPorCem();
            produto.DividirValorVendaPorCem();
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