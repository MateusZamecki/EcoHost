using EcoHost.Models;
using ProjetoIntegradorMVC.Models.Repositorio.Interfaces;
using System;

namespace ProjetoIntegradorMVC.Models.Repositorio.Interfaces
{
    public class RepositorioFornecedor : RepositorioBase<Fornecedor>, IRepositorioFornecedor
    {
        public RepositorioFornecedor(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
