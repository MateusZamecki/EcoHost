using System;

namespace EcoHost.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public bool EhFuncionario { get; set; } = false;
        public DateTime DataCadastro { get; set; }
    }
}