using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Robinho_Questao_2
{
    public class Triangulo:Forma
    {
        public double ladoA;
        public double ladoB;
        public double ladoC;

        public override void CalcularArea()
        {
            Console.WriteLine("Escreva o valor da base do triangulo:");
            double BaseTriangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o valor da altura do triangulo:");
            double AlturaTriangulo = double.Parse(Console.ReadLine());

            Area = (BaseTriangulo * AlturaTriangulo) / 2;
            Console.WriteLine("Área do triângulo: " + Area);
        }

        public override void CalcularPerimetro()
        {
            Console.WriteLine("Digite o valor do lado A do triângulo");
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado B do triângulo");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado C do triângulo");
            double C = double.Parse(Console.ReadLine());


            if (A == B && B == C)
            {
                Console.Write("Esse triângulo é: \t");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Equilátero \n");
                Console.ResetColor();

                double Perimetro = A + B + C;
                Console.WriteLine("O perimetro do triagulo é:" + Perimetro);

            }
            else if (A == B || A == C || B == C)
            {
                Console.Write("Esse triângulo é:");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Isósceles \n");
                Console.ResetColor();

                double Perimetro = A + B + C;
                Console.WriteLine("O perimetro do triagulo é:" + Perimetro);

            }
            else if (A != C && A != B && B != C)
            {
                Console.Write("Esse triângulo é: \t");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Escaleno \n");
                Console.ResetColor();

                double Perimetro = A + B + C;
                Console.WriteLine("O perimetro do triagulo é:" + Perimetro);
            }
        }
    }
}
