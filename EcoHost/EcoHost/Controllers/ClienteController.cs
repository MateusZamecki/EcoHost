using EcoHost.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoIntegradorMVC.Ajudantes;
using ProjetoIntegradorMVC.Models.Repositorio;
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
        public IActionResult PrincipalCliente()
        {
            List<Produto> produtos = oProdutoService.oRepositorioProduto.SelecionarTodos();
            foreach (var produto in produtos)
            {
                var categoria = consulta.BuscarCategoriaPorId(produto.CategoriaId);
                produto.AdicionarCategoria(categoria);
            }
            return View(produtos);
        }
        public IActionResult AdicionarAoCarrinho()
        {
            var produtos = oProdutoService.oRepositorioProduto.SelecionarTodos();
            return View(produtos);
        }
    }
}