using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    public class Comissionado : Empregado
    {
        public double totalVenda { get; set; }
        public double taxaComissao { get; set; }

        public override double Vencimento()
        {
            Console.WriteLine("Quanto em porcentagem que você ganha?");
            taxaComissao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quanto você vendeu?");
            totalVenda = double.Parse(Console.ReadLine());

            double porcentagem = taxaComissao / 100;
            double ganho = porcentagem * totalVenda;

            return ganho;
        }
    }
}
