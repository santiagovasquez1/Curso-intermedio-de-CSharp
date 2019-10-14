using System;

namespace Programa01
{
    internal class CSuma : Ioperaciones
    {
        private double r = 0;

        public void Mostrar()
        {
            Console.WriteLine("El resultado de la suma es {0}", r);
        }

        public void Calcular(double a, double b)
        {
            r = a + b;
        }
    }
}