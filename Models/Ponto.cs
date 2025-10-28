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
        
        public int IdPonto { get; set; }
        public DateOnly RegistroDataPonto { get; set; }
        public TimeOnly RegistroHoraPonto { get; set; }
        public Funcionario FuncionarioVinculadoAoPonto { get; set; }
    }
}