using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Robinho_Questao_2
{
    public class Quadrado : Forma
    {
        public override void CalcularArea()
        {
            Console.WriteLine("Escreva o valor de um lado do quadrado:");
            double LadoQuadrado = double.Parse(Console.ReadLine());

            Area = LadoQuadrado * LadoQuadrado;
            Console.WriteLine("Área do quadrado: " + Area);
        }

        public override void CalcularPerimetro()
        {
            Console.WriteLine("Escreva o valor de um lado do quadrado:");
            double LadoQuadrado = double.Parse(Console.ReadLine());

            Perimetro = (int)LadoQuadrado * 4;
            Console.WriteLine("Perímetro do quadrado: " + Perimetro);
        }
    }
}
