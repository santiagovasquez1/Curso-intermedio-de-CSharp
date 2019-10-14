using System;

namespace Programa01
{
    internal class CDiv : Ioperaciones
    {
        private double r = 0;

        public void Mostrar()
        {
            Console.WriteLine("El resultado de la division es {0}", r);
        }

        public void Calcular(double a, double b)
        {
            r = a / b;
        }
    }
}