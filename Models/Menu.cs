using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjetoPonto.Models
{
    
    public class Menu
    {
        private GerenciadorFuncionario controlerFuncionario;
        private GerenciadorPontos controlerPonto;
        private MenuFuncionario menuFuncionario;
        private MenuPonto menuPonto;

        public Menu()
        {
            controlerFuncionario = new GerenciadorFuncionario();
            controlerPonto = new GerenciadorPontos();

            menuFuncionario = new MenuFuncionario(controlerFuncionario);
            menuPonto = new MenuPonto(controlerPonto);
        }

        
        bool menuFuncional = true;
        string escolhaUsuario;
        
        public void OpcoesMenu()
        {

            Console.WriteLine("========== MENU ==========");
            Console.WriteLine("1 - Cadastrar Funcionário");
            Console.WriteLine("2 - Efetuar Registro de Ponto");
            Console.WriteLine("3 - Alterar Cadastro de Funcionário");
            Console.WriteLine("4 - Alterar Registro de Ponto");
            Console.WriteLine("5 - Listar Funcionários Cadastrados");
            Console.WriteLine("6 - Listar Pontos Cadastrados");
            Console.WriteLine("0 - Sair do Programa");
            Console.WriteLine("==========================");
        }

        public void Executar()
        {

            OpcoesMenu();

            while (menuFuncional)
            {

                escolhaUsuario = Console.ReadLine();

                switch (escolhaUsuario)
                {
                    case "1":
                        menuFuncionario.CadastrarFuncionario();
                        Console.WriteLine("Para exibir o menu novamente pressione 9");
                        break;

                    case "2":
                        Funcionario funcionario = menuFuncionario.BuscarFuncionario();
                        DateOnly data = menuPonto.CadastrarDataPonto();
                        TimeOnly hora = menuPonto.CadastrarHoraPonto();

                        controlerPonto.AdicionarRegistroPonto(data, hora, funcionario);

                        Console.WriteLine("Ponto Cadastrado com sucesso!");
                        Console.WriteLine("Para exibir o menu novamente pressione 9");
                        break;

                    case "3":
                        menuFuncionario.AlteracaoCadastroFuncionarios();
                        Console.WriteLine("Para exibir o menu novamente pressione 9");
                        break;

                    case "4":
                        menuPonto.AlterarCadastroPonto();
                        Console.WriteLine("Para exibir o menu novamente pressione 9");
                        break;

                    case "5":
                        Console.WriteLine("Funcionários Cadastrados: ");
                        controlerFuncionario.ListarFuncionariosCadastrados();
                        Console.WriteLine("Para exibir o menu novamente pressione 9");
                        break;

                    case "6":
                        Console.WriteLine("Pontos Cadastrados: ");
                        controlerPonto.ListarPontos();
                        Console.WriteLine("Para exibir o menu novamente pressione 9");
                        break;
                        
                    case "9":
                        OpcoesMenu();
                        break;

                    case "0":
                        menuFuncional = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        OpcoesMenu();
                        break;
                }
            } 
        }
        
    }
}