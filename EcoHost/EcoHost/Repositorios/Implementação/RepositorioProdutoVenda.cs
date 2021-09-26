using EcoHost.Models;
using ProjetoIntegradorMVC.Models.Repositorio.Interfaces;
using System;

namespace ProjetoIntegradorMVC.Models.Repositorio.Interfaces
{
    public class RepositorioProdutoVenda : RepositorioBase<ProdutoVenda>, IRepositorioProdutoVenda
    {
        public RepositorioProdutoVenda(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
