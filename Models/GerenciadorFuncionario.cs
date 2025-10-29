using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPonto.Models
{
    public class GerenciadorFuncionario
    {
        public List<Funcionario> listagemFuncionarios = new List<Funcionario>();
        private int proximoIdFuncionario = 1;

        public void AdicionaFuncionario(string nome, string cpf)
        {
            Funcionario novofuncionario = new Funcionario(proximoIdFuncionario, nome, cpf);
            listagemFuncionarios.Add(novofuncionario);
            proximoIdFuncionario++;

        }
    }
}