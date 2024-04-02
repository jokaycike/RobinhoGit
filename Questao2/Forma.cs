using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Robinho_Questao_2
{
    public abstract class Forma
    {
        public double Area;
        public int Perimetro;

        public abstract void CalcularArea();

        public abstract void CalcularPerimetro();
       
    }
}
