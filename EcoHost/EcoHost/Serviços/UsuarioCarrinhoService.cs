using EcoHost.Models;
using Microsoft.EntityFrameworkCore;
using ProjetoIntegradorMVC.Models.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoIntegradorMVC.Models.Repositorio
{
    public class UsuarioCarrinhoService
    {
        public RepositorioUsuarioCarrinho oRepositorioUsuarioCarrinho { get; set; }            
        public UsuarioCarrinhoService()
        {
            oRepositorioUsuarioCarrinho = new();
        }
    }
}