using EcoHost.Models;
using ProjetoIntegradorMVC.Models.Repositorio.Interfaces;
using System;
using System.Linq;

namespace ProjetoIntegradorMVC.Models.Repositorio.Interfaces
{
    public class RepositorioUsuario : RepositorioBase<Usuario>, IRepositorioUsuario
    {
        public RepositorioUsuario(bool SaveChanges = true) : base(SaveChanges)
        {

        }
        public Usuario SelecionarPorEmail(string email)
        {
            var usuarios = _contexto.Usuarios.ToList();
            foreach(var usuario in usuarios)
            {
                if (usuario.Email.Equals(email))
                {
                    return usuario;
                }
            }
            return null;
        }
    }
}
