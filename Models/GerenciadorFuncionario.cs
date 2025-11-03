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

        public void RemoverFuncionario(int id)
        {
            for (int i = 0; i < listagemFuncionarios.Count; i++)
            {
                if (listagemFuncionarios[i].IdFuncionario == id)
                {
                    listagemFuncionarios.RemoveAt(i);
                }
            }
        }

        public void AlteraNomeFuncionario(int id, string novoNome)
        {
            foreach (Funcionario funcionario in listagemFuncionarios)
            {
                if (funcionario.IdFuncionario == id)
                {
                    funcionario.NomeFuncionario = novoNome;
                }
            }
        }

        public void AlteraCpfFuncionario(int id, string novoCpf)
        {
            foreach (Funcionario funcionario in listagemFuncionarios)
            {
                if (funcionario.IdFuncionario == id)
                {
                    funcionario.CpfFuncionario = novoCpf;
                }
            }
        }

        public void ListarFuncionariosCadastrados()
        {
            foreach (Funcionario funcionario in listagemFuncionarios)
            {
                Console.WriteLine($"ID: {funcionario.IdFuncionario} | Nome: {funcionario.NomeFuncionario} | CPF: {funcionario.CpfFuncionario}");
            }
        }

        public Funcionario BuscarFuncionarioPorId(int id)
        {
            foreach (Funcionario funcionario in listagemFuncionarios)
            {
                if (funcionario.IdFuncionario == id)
                {
                    return funcionario;
                }
            }

            Console.WriteLine("Funcionário não encontrado!");
            return null;
        }
    }
}