using System;

namespace EcoHost.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public int UsuarioId { get; set; }
        public int CarrinhoId { get; set; }
        public Usuario Usuario { get; set; }
        public Carrinho Carrinho { get; set; }
    }
}
