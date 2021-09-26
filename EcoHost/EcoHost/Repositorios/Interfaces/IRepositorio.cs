using System;
using System.Collections.Generic;

namespace ProjetoIntegradorMVC.Models.Repositorio.Interfaces
{    public interface IRepositorio<T> where T : class
    {
        List<T> SelecionarTodos();
        T SelecionarPorId(params object[] variavel);
        T Incluir(T objeto);
        T Alterar(T objeto);
        void Excluir(T objeto);
        void Excluir(params object[] variavel);
        void SalvarAlteracoes();
    }
}
