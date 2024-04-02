using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    public abstract class Empregado
    {
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string cpf { get; set; }


        public abstract double BuscarVencimento();
    }
}
