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
        public void AdicionarCategoria(Categoria categoria)
        {
            Categoria = categoria;
        }
        public void AdicionarFornecedor(Fornecedor fornecedor)
        {
            Fornecedor = fornecedor;
        }
    }
}
