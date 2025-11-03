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

        private string _nomeFuncionario;
        private string _cpfFuncionario;

        public int IdFuncionario { get; private set; }
        public string NomeFuncionario 
        { 
            get => _nomeFuncionario;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome do funcionário não pode ser vazio");
                }

                _nomeFuncionario = value;
            }
        }

        public string CpfFuncionario 
        { 
            get => _cpfFuncionario;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O cpf do funcionário não pode ser vazio!");
                }

                _cpfFuncionario = value;
            }
        }
    }
}