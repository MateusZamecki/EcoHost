using EcoHost.Models;
using ProjetoIntegradorMVC.Models.Repositorio.Interfaces;
using System;

namespace ProjetoIntegradorMVC.Models.Repositorio.Interfaces
{
    public class RepositorioUsuario : RepositorioBase<Usuario>, IRepositorioUsuario
    {
        public RepositorioUsuario(bool SaveChanges = true) : base(SaveChanges)
        {

        }
        public Usuario SelecionarPorEmail(string email)
        {
            var usuario = _contexto.Usuarios.Find(email);
            return usuario;
        }
    }
}
