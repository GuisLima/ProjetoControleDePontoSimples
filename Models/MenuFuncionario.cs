using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPonto.Models
{
    public class MenuFuncionario
    {
        GerenciadorFuncionario controlerFuncionario = new GerenciadorFuncionario();

        public void CadastrarFuncionario()
        {
            Console.WriteLine("Digite o nome do funcionário: ");
            string nomeFuncionario = Console.ReadLine();

            Console.Write("Digite o CPF do funcionário: ");
            string cpfFuncionario = Console.ReadLine();

            controlerFuncionario.AdicionaFuncionario(nomeFuncionario, cpfFuncionario);
            Console.WriteLine("Inserção efetuada com sucesso!");
        }

        public Funcionario BuscarFuncionario()
        {
            string escolhaUsuario;
            while (true)
            {
                Console.WriteLine("===== Funcionários =====");
                Console.WriteLine("1 - Listar Todos os Funcionários");
                Console.WriteLine("2 - Selecionar funcionário pela ID");

                escolhaUsuario = Console.ReadLine();

                switch (escolhaUsuario)
                {
                    case "1":
                        controlerFuncionario.ListarFuncionariosCadastrados();
                        break;

                    case "2":
                        Console.WriteLine("Digite a ID do Funcionário: ");
                        int idFuncionario = Convert.ToInt32(Console.ReadLine());

                        if (idFuncionario <= 0)
                        {
                            Console.WriteLine("O valor não pode ser zero ou negativo");
                            break;
                        }

                        Funcionario funcionario = controlerFuncionario.BuscarFuncionarioPorId(idFuncionario);

                        if (funcionario == null)
                        {
                            break;
                        }

                        Console.WriteLine($"Funcionário selecionado: {funcionario.NomeFuncionario} | {funcionario.CpfFuncionario}");
                        return funcionario;


                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

    }
}