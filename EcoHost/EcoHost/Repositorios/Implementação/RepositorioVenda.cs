using EcoHost.Models;
using ProjetoIntegradorMVC.Models.Repositorio.Interfaces;
using System;

namespace ProjetoIntegradorMVC.Models.Repositorio.Interfaces
{
    public class RepositorioVenda : RepositorioBase<Venda>, IRepositorioVenda
    {
        public RepositorioVenda(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
