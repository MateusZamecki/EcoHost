using EcoHost.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoIntegradorMVC.Ajudantes;
using ProjetoIntegradorMVC.Models.Repositorio;
using System;
using System.Collections.Generic;

namespace Controle_De_Estoque.Controllers
{
    public class ClienteController : Controller
    {
        private ProdutoService oProdutoService = new();
        private CategoriaService oCategoriaService = new();
        private FornecedorService oFornecedorService = new();
        private VendaService oVendaService = new();
        private UsuarioService oUsuarioService = new();
        private ConsultaPorId consulta = new();

        public IActionResult Principal()
        {
            var produtos = oProdutoService.oRepositorioProduto.SelecionarTodos();
            foreach (var produto in produtos)
            {
                var categoria = consulta.BuscarCategoriaPorId(produto.CategoriaId);
                produto.AdicionarCategoria();
            }
            return View(produtos);
        }

        public IActionResult AdicionarAoCarrinho()
        {
            var produtos = oProdutoService.oRepositorioProduto.SelecionarTodos();
            return View(produtos);
        }

        public IActionResult Pesquisar(string pesquisa)
        {
            if (String.IsNullOrEmpty(pesquisa))
            {
                return RedirectToAction("Principal");
            }
            var produtos = oProdutoService.oRepositorioProduto.SelecionarTodos();
            var produtosPesquisados = produtos.FindAll(produto => produto.Nome.ToLower().StartsWith(pesquisa.ToLower()));
            foreach(var produto in produtosPesquisados)
            {
                var categoria = consulta.BuscarCategoriaPorId(produto.CategoriaId);
                produto.AdicionarCategoria();
            }
            return View(produtosPesquisados);
        }
    }
}