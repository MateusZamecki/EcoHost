using EcoHost.Models;
using ProjetoIntegradorMVC.Models.Repositorio.Interfaces;
using System;

namespace ProjetoIntegradorMVC.Models.Repositorio.Interfaces
{
    public class RepositorioCategoria : RepositorioBase<Categoria>, IRepositorioCategoria
    {
        public RepositorioCategoria(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
