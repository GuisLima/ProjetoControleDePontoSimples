using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjetoPonto.Models
{
    public class GerenciadorPontos
    {
        public List<Ponto> listaPontosRegistrados = new List<Ponto>();
        private int proximoId = 1;

        public void AdicionarRegistroPonto(DateOnly data, TimeOnly horario, Funcionario funcionario)
        {
            Ponto novoPonto = new Ponto(proximoId, data, horario, funcionario);
            listaPontosRegistrados.Add(novoPonto);
            proximoId++;
        }

        public void RemoverRegistroPonto()
        {
            // TODO: Criar a lógica
        }

        public void AlterarHorarioPonto()
        {
            // TODO: Criar a lógica
        }

        public void AlterarDataPonto()
        {
            // TODO: Criar a lógica
        }

        public void ListarPontos()
        {
            foreach (var ponto in listaPontosRegistrados)
            {
                Console.WriteLine($"{ponto.FuncionarioVinculadoAoPonto.NomeFuncionario}, {ponto.RegistroDataPonto}, {ponto.RegistroHoraPonto}, {ponto.IdPonto}");
            }
        }

        
    }
}