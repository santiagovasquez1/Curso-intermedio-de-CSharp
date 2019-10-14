using System;

namespace Programa01
{
    internal class CMulti : Ioperaciones
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