using EcoHost.Models;
using Microsoft.EntityFrameworkCore;
using ProjetoIntegradorMVC.Models.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoIntegradorMVC.Models.Repositorio
{
    public class VendaService
    {
        public RepositorioVenda oRepositorioVenda { get; set; }            
        public VendaService()
        {
            oRepositorioVenda = new RepositorioVenda();
        }
    }
}