using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPonto.Models
{
    public class Ponto
    {
        public Ponto(int id, DateOnly data, TimeOnly horario, Funcionario funcionario)
        {
            IdPonto = id;
            RegistroDataPonto = data;
            RegistroHoraPonto = horario;
            FuncionarioVinculadoAoPonto = funcionario;
        }

        private DateOnly _registroDataPonto;
        private TimeOnly _registroHoraPonto;
        private Funcionario _funcionarioVinculadoAoPonto;
        
        public int IdPonto { get; private set; }
        public DateOnly RegistroDataPonto 
        { 
            get => _registroDataPonto;

            set
            {
                if (value == default)
                {
                    throw new ArgumentException("A data do ponto não pode ser vazia");
                }

                _registroDataPonto = value;

            }
        }
        public TimeOnly RegistroHoraPonto 
        { 
            get => _registroHoraPonto;
            
            set
            {
                if (value == default)
                {
                    throw new ArgumentException("O horário do ponto não pode ser vazio");
                }

                _registroHoraPonto = value;
            } 
        }

        public Funcionario FuncionarioVinculadoAoPonto 
        { 
            get => _funcionarioVinculadoAoPonto;

            set
            {
                if (value == null)
                {
                    throw new ArgumentException(nameof(FuncionarioVinculadoAoPonto), "O ponto deve estar vinculado a um funcionário válido.");
                }

                _funcionarioVinculadoAoPonto = value;
            }
        }
    }
}