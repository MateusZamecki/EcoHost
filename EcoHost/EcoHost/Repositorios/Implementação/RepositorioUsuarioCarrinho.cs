using EcoHost.Models;
using ProjetoIntegradorMVC.Models.Repositorio.Interfaces;
using System;

namespace ProjetoIntegradorMVC.Models.Repositorio.Interfaces
{
    public class RepositorioUsuarioCarrinho : RepositorioBase<UsuarioCarrinho>, IRepositorioUsuarioCarrinho
    {
        public RepositorioUsuarioCarrinho(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
