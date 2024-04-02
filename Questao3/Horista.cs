using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    public class Horista : Empregado
    {
        public double precoHora { get; set; }
        public double horasTrabalhadas { get; set; }

        public override double Vencimento()
        {
            Console.WriteLine("Quanto você recebe por hora?");
            precoHora = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas você trabalhou");
            horasTrabalhadas = double.Parse(Console.ReadLine());

            double receber = precoHora * horasTrabalhadas;
            return receber;
        }
    }
}
