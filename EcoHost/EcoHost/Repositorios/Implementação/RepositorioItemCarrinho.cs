using EcoHost.Models;
using ProjetoIntegradorMVC.Models.Repositorio.Interfaces;
using System;

namespace ProjetoIntegradorMVC.Models.Repositorio.Interfaces
{
    public class RepositorioItemCarrinho : RepositorioBase<ItemCarrinho>, IRepositorioItemCarrinho
    {
        public RepositorioItemCarrinho(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
