using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoPonto.Models
{
    public class MenuPonto
    {
        private readonly GerenciadorPontos _controlador;
        
        public MenuPonto(GerenciadorPontos controlador)
        {
            _controlador = controlador;
        }
        
        public DateOnly CadastrarDataPonto()
        {

            while (true)
            {

                Console.WriteLine("Digite a data do ponto (dd/MM/yyyy): ");
                string dataDigitada = Console.ReadLine();

                if (DateOnly.TryParseExact(dataDigitada, "dd/MM/yyyy", null, DateTimeStyles.None, out DateOnly dataConvertida))
                {
                    Console.WriteLine("Data cadastrada com sucesso!");
                    return dataConvertida;
                }
                else
                {
                    Console.WriteLine("Formato de data inválido! Utilizar dd/MM/yyyy");
                }
            }
        }

        public TimeOnly CadastrarHoraPonto()
        {
            while (true)
            {
                Console.WriteLine("Digite a hora do ponto (HH:mm)");
                string horaDigitada = Console.ReadLine();

                if (TimeOnly.TryParseExact(horaDigitada, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out TimeOnly horaconvertida))
                {
                    return horaconvertida;
                }
                else
                {
                    Console.WriteLine("Formato de hora inválido! Use HH:mm");
                }
            }
        }

        public Ponto BuscarPonto()
        {
            string escolhaUsuario;
            while (true)
            {
                Console.WriteLine("===== Pontos Registrado =====");
                Console.WriteLine("1 - Listar Todos os Pontos Cadastrados");
                Console.WriteLine("2 - Selecionar Ponto por ID");

                escolhaUsuario = Console.ReadLine();

                switch (escolhaUsuario)
                {
                    case "1":
                        _controlador.ListarPontos();
                        break;

                    case "2":
                        Console.WriteLine("Digite a ID do Ponto: ");
                        int idPonto = Convert.ToInt32(Console.ReadLine());

                        if (idPonto <= 0)
                        {
                            Console.WriteLine("O valor não pode ser zero ou negativo");
                            break;
                        }

                        Ponto ponto = _controlador.BuscarPontoPorId(idPonto);

                        if (ponto == null)
                        {
                            break;
                        }

                        Console.WriteLine($"Ponto selecionado: ID - {ponto.IdPonto} | DATA - {ponto.RegistroDataPonto} | HORA - {ponto.RegistroHoraPonto}" +
                                                                            $"FUNCIONARIO - {ponto.FuncionarioVinculadoAoPonto}");
                        return ponto;


                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        
        public void AlteraCadastroPonto()
        {
            
        }
    }
}