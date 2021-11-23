using ProjetoIntegradorMVC.Models.Repositorio;
using System;

namespace EcoHost.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double ValorVenda { get; set; }
        public double CustoCompra { get; set; }
        public int Quantidade { get; set; }
        public string Drescricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int CategoriaId { get; set; }
        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Categoria Categoria { get; set; }
        private CategoriaService oCategoriaService = new();
        private FornecedorService oFornecedorService = new();
        public void AdicionarCategoria()
        {
            Categoria = oCategoriaService.oRepositorioCategoria.SelecionarPorId(CategoriaId);
        }
        public void AdicionarFornecedor()
        {
            Fornecedor = oFornecedorService.oRepositorioFornecedor.SelecionarPorId(FornecedorId);
        }
        public void DividirCustoDaCompraPorCem()
        {
            CustoCompra /= 100;
        }
        public void DividirValorVendaPorCem()
        {
            ValorVenda /= 100;
        }
    }
}
