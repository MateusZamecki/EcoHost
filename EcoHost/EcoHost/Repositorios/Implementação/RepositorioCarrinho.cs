using EcoHost.Models;
using ProjetoIntegradorMVC.Models.Repositorio.Interfaces;
using System;

namespace ProjetoIntegradorMVC.Models.Repositorio.Interfaces
{
    public class RepositorioCarrinho : RepositorioBase<Carrinho>, IRepositorioCarrinho
    {
        public RepositorioCarrinho(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
