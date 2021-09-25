using System;

namespace EcoHost.Models
{
    public class UsuarioCarrinho
    {
        public int Id { get; set; }
        public int CarrinhoId { get; set; }
        public int UsuarioId { get; set; }
        public Carrinho Carrinho { get; set; }
        public Usuario Usuario { get; set; }
    }
}
