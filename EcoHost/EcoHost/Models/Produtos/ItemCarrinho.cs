using System;

namespace EcoHost.Models
{
    public class ItemCarrinho
    {
        public int Id { get; set; }
        public int CarrinhoId { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public Carrinho Carrinho { get; set; }
    }
}
