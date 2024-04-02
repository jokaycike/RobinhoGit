using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    public class Menu
    {
        public void Buscar()
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome:");
            string sobrenome = Console.ReadLine();

            Console.WriteLine("Digite seu CPF");
            string cpf = Console.ReadLine();

            Assalariado assalariado = new Assalariado();
            Comissionado comissionado = new Comissionado();
            Horista horista = new Horista();


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Que tipo de trabalhador você é:");
                Console.WriteLine("1 - Assalariado");
                Console.WriteLine("2 - Comissionado");
                Console.WriteLine("3 - Horista");
                Console.WriteLine("0 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        assalariado.nome = nome;
                        assalariado.sobrenome = sobrenome;
                        assalariado.cpf = cpf;
                        assalariado.BuscarVencimento();
                        Console.Write("Você ganha:");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(assalariado.salario.ToString("C"));
                        Console.ResetColor();
                        break;
                    case "2":
                        comissionado.nome = nome;
                        comissionado.sobrenome = sobrenome;
                        comissionado.cpf = cpf;
                        double ganho = comissionado.BuscarVencimento();
                        Console.Write("Você recebe a comissão de:");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(comissionado.taxaComissao + "%");
                        Console.ResetColor();
                        Console.Write("Você vendeu:");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(comissionado.totalVenda.ToString("C"));
                        Console.ResetColor();
                        Console.Write("Você ganha então:");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(ganho.ToString("C"));
                        Console.ResetColor();
                        break;
                    case "3":
                        horista.nome = nome;
                        horista.sobrenome = sobrenome;
                        horista.cpf = cpf;
                        double receber = horista.BuscarVencimento();
                        Console.Write("Você ganha por hora:");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(horista.precoHora.ToString("C"));
                        Console.ResetColor();
                        Console.Write("Você trabalhou:");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(horista.horasTrabalhadas + "hrs");
                        Console.ResetColor();
                        Console.Write("Então você vai receber:");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(receber.ToString("C"));
                        Console.ResetColor();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
