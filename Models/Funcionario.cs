using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPonto.Models
{
    public class Funcionario
    {

        public Funcionario(int id, string nome, string cpf)
        {
            IdFuncionario = id;
            NomeFuncionario = nome;
            CpfFuncionario = cpf;
        }
        public int IdFuncionario { get; set; }
        public string NomeFuncionario { get; set; }
        public string CpfFuncionario { get; set; }
    }
}