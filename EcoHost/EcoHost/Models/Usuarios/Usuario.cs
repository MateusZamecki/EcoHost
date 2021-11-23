using System;

namespace EcoHost.Models
{
    public class Usuario
    {
        public Usuario(int id, string nome, string senha, string email, string estado, string cidade, bool ehFuncionario, DateTime dataCadastro)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Email = email;
            Estado = estado;
            Cidade = cidade;
            EhFuncionario = ehFuncionario;
            DataCadastro = dataCadastro;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public bool EhFuncionario { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
