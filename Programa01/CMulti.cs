using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01
{
    class CMulti : Ioperaciones
    {
        private double r;
        public void Mostrar()
        {
            Console.WriteLine("El resultado de la multiplicacion es {0}", r);
        }

        public void Calcular(double a, double b)
        {
            r = a * b;
        }
    }
}
