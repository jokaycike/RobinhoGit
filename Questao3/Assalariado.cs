using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    public class Assalariado : Empregado
    {
        public double salario { get; set; }

        public override double Vencimento()
        {
            Console.WriteLine("Quanto você recebe no seu salario?");
            salario = double.Parse(Console.ReadLine());
            return salario;
        }
    }
}
