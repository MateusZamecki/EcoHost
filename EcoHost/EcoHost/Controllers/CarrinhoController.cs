using EcoHost.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoIntegradorMVC.Models.Repositorio;
using System.Collections.Generic;

namespace Controle_De_Estoque.Controllers
{
    public class CarrinhoController : Controller
    {
        private ProdutoService oProdutoService = new();
        private CategoriaService oCategoriaService = new();
        private FornecedorService oFornecedorService = new();
        private VendaService oVendaService = new();
        private UsuarioService oUsuarioService = new();
        public IActionResult Principal()
        {
            return View();
        }
        public IActionResult AdicionarProduto()
        {
            List<Produto> produtos = oProdutoService.oRepositorioProduto.SelecionarTodos();
            return View(produtos);
        }
        public IActionResult RemoverProduto()
        {
            var produtos = oProdutoService.oRepositorioProduto.SelecionarTodos();
            return View(produtos);
        }
    }
}