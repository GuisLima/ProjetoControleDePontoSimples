using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPonto.Models
{
    public class MenuFuncionario
    {
        public MenuFuncionario(GerenciadorFuncionario controlador)
        {
            ControlerFuncionario = controlador;
        }
        public GerenciadorFuncionario ControlerFuncionario { get; set; }

        public void CadastrarFuncionario()
        {
            Console.WriteLine("Digite o nome do funcionário: ");
            string nomeFuncionario = Console.ReadLine();

            Console.Write("Digite o CPF do funcionário: ");
            string cpfFuncionario = Console.ReadLine();

            ControlerFuncionario.AdicionaFuncionario(nomeFuncionario, cpfFuncionario);
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
                        ControlerFuncionario.ListarFuncionariosCadastrados();
                        break;

                    case "2":
                        Console.WriteLine("Digite a ID do Funcionário: ");
                        int idFuncionario = Convert.ToInt32(Console.ReadLine());

                        if (idFuncionario <= 0)
                        {
                            Console.WriteLine("O valor não pode ser zero ou negativo");
                            break;
                        }

                        Funcionario funcionario = ControlerFuncionario.BuscarFuncionarioPorId(idFuncionario);

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

        public void AlteracaoCadastroFuncionarios()
        {
            Console.WriteLine("Selecione a informação que deseja alterar:");
            Console.WriteLine("1 - Nome do Funcionário");
            Console.WriteLine("2 - CPF do Funcionário");
            Console.WriteLine("0 - Voltar ao Menu Anterior");

            string entradaUsuario = Console.ReadLine();

            switch (entradaUsuario)
            {
                case "1":
                    Funcionario funcionarioNome = BuscarFuncionario();
                    Console.WriteLine("Digite o novo nome do funcionário: ");
                    string alteracaoNome = Console.ReadLine();
                    ControlerFuncionario.AlteraNomeFuncionario(funcionarioNome, alteracaoNome);
                    Console.WriteLine("Alteração efetuada com sucesso!");
                    break;

                case "2":
                    Funcionario funcionarioCpf = BuscarFuncionario();
                    Console.WriteLine("Digite o novo nome do funcionário: ");
                    string alteracaoCpf = Console.ReadLine();
                    ControlerFuncionario.AlteraCpfFuncionario(funcionarioCpf, alteracaoCpf);
                    Console.WriteLine("Alteração efetuada com sucesso!");
                    break;
            }
        }

    }
}