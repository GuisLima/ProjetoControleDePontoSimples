using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjetoPonto.Models
{
    public class GerenciadorPontos
    {
        public List<Ponto> listaPontosRegistrados = new List<Ponto>();
        public Ponto PontosFuncionarios { get;}
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

        public void AlterarHorarioPonto(int id, TimeOnly novoHorario)
        {
            foreach (var idHorarioRegistrado in listaPontosRegistrados)
            {
                if (idHorarioRegistrado.IdPonto == id)
                {
                    idHorarioRegistrado.RegistroHoraPonto = novoHorario;
                }
            }
        }

        public void AlterarDataPonto(int id, DateOnly novaData)
        {
            foreach (var idDataRegistrada in listaPontosRegistrados)
            {
                if (idDataRegistrada.IdPonto == id)
                {
                    idDataRegistrada.RegistroDataPonto = novaData;
                }
            }
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