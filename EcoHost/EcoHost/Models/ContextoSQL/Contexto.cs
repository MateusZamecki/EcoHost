using Microsoft.EntityFrameworkCore;
using System;

namespace EcoHost.Models.ContextoSQL
{
    public class Contexto : DbContext
    {
        public Contexto()
        {
        }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conexaoTexto = new Conexao().Texto();
            optionsBuilder.UseSqlServer(conexaoTexto);
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ItemCarrinho> ItensCarrinho { get; set; }
        public DbSet<Carrinho> Carrinhos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ProdutoVenda> ProdutosVenda { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<UsuarioCarrinho> UsuarioCarrinhos { get; set; }
    }
}
