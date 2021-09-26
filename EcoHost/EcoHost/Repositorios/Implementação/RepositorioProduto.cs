using EcoHost.Models;
using ProjetoIntegradorMVC.Models.Repositorio.Interfaces;
using System;

namespace ProjetoIntegradorMVC.Models.Repositorio.Interfaces
{
    public class RepositorioProduto : RepositorioBase<Produto>, IRepositorioProduto
    {
        public RepositorioProduto(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
