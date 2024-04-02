using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Robinho_Questao_2
{
    public class Circunferencia:Forma
    {
        public double raio;

        public override void CalcularArea()
        {
            Console.WriteLine("Digite o raio da circunferencia:");
            raio = double.Parse(Console.ReadLine());

            double Area = 3.14 * (raio * raio);
            Console.WriteLine("Área da circunferência: " + Area);
        }

        public override void CalcularPerimetro()
        {
            Console.WriteLine("Digite o raio da circunferencia:");
            raio = double.Parse(Console.ReadLine());

            double Perimetro = 2 * 3.14 * raio;
            Console.WriteLine("Perímetro da circunferência: " + Perimetro);
        }
    }
}
