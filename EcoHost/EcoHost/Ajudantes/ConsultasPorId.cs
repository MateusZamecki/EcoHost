using EcoHost.Models;
using EcoHost.Models.ContextoSQL;
using Microsoft.EntityFrameworkCore;
using ProjetoIntegradorMVC.Models.Repositorio;
using ProjetoIntegradorMVC.Models.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoIntegradorMVC.Ajudantes
{
    public class ConsultaPorId
    {
        private ProdutoService oProdutoService = new();
        private CategoriaService oCategoriaService = new();
        private FornecedorService oFornecedorService = new();
        public Produto BuscarProdutoPorId(int id)
        {
            var produto = oProdutoService.oRepositorioProduto.SelecionarPorId(id);
            return produto;
        }
        public Categoria BuscarCategoriaPorId(int id)
        {
            var categoria = oCategoriaService.oRepositorioCategoria.SelecionarPorId(id);
            return categoria;
        }
        public Fornecedor BuscarFornecedorPorId(int id)
        {
            var fornecedor = oFornecedorService.oRepositorioFornecedor.SelecionarPorId(id);
            return fornecedor;
        }
    }
}