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

        public void RemoverRegistroPonto(int id)
        {
            for (int i = 0; i < listaPontosRegistrados.Count; i++)
            {
                if (listaPontosRegistrados[i].IdPonto == id)
                {
                    listaPontosRegistrados.RemoveAt(i);
                }
            }
        }

        public void AlterarHorarioPonto(Ponto id, TimeOnly novoHorario) => id.RegistroHoraPonto = novoHorario;

        public void AlterarDataPonto(Ponto id, DateOnly novaData) => id.RegistroDataPonto = novaData;

        public void ListarPontos()
        {
            foreach (var ponto in listaPontosRegistrados)
            {
                Console.WriteLine($"{ponto.FuncionarioVinculadoAoPonto.NomeFuncionario}, {ponto.RegistroDataPonto}, {ponto.RegistroHoraPonto}, {ponto.IdPonto}");
            }
        }

        
    }
}