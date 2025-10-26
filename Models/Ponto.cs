using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPonto.Models
{
    public class Ponto
    {
        public DateOnly RegistroDataPonto { get; set; }
        public TimeOnly RegistroHoraPonto { get; set; }
        //public Funcionario FuncionarioVinculadoAoPonto { get; set; }
    }
}