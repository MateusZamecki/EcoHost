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
            var conexaoTexto = new Categoria().Texto();
            optionsBuilder.UseSqlServer(conexaoTexto);
        }
    }
}
