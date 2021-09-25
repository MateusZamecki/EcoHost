using System;

namespace EcoHost.Models
{
    public class ProdutoVenda
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public int IdVenda { get; set; }
        public int IdProduto { get; set; }
        public Venda Venda { get; set; }
        public Produto Produto { get; set; }
    }
}
