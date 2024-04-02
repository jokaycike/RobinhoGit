using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Robinho_Questao_2
{
    public class GerarForma
    {
        public void SolicitarForma()
        {
            Quadrado quadrado = new Quadrado();
            Triangulo triangulo = new Triangulo();
            Circunferencia circunferencia = new Circunferencia();



            while (true)
            {
                Console.Clear();    
                Console.WriteLine("Escolha o que você quer fazer:");
                Console.WriteLine("1 - Area Quadrado");
                Console.WriteLine("2 - Perimetro Quadrado");
                Console.WriteLine("3 - Area Triangulo");
                Console.WriteLine("4 - Perimetro Triangulo");
                Console.WriteLine("5 - Area Circunferencia");
                Console.WriteLine("6 - Perimetro Circunferencia");
                Console.WriteLine("0 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        quadrado.CalcularArea();
                        break;
                    case "2":
                        quadrado.CalcularPerimetro();
                        break;
                    case "3":
                        triangulo.CalcularArea();
                        break;
                    case "4":
                        triangulo.CalcularPerimetro();
                        break;
                    case "5":
                        circunferencia.CalcularArea();
                        break;
                    case "6":
                        circunferencia.CalcularPerimetro();
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
