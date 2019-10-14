using System;

namespace Programa01
{
    internal class CResta : Ioperaciones
    {
        private double r = 0;

        public void Mostrar()
        {
            Console.WriteLine("El resultado de la resta es {0}", r);
        }

        public void Calcular(double a, double b)
        {
            r = a - b;
        }
    }
}