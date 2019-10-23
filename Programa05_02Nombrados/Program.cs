using Operaciones_Basicas;
using System;

namespace Programa05_02Nombrados
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double r = 0;
            //Invocamos normal
            MostrarDatos(3, 5, 7);

            //Invocamos con primero normal, los demas en diferentes orden
            MostrarDatos(pA: 3, pC: 11, pB: 15);

            //Uso de opcionales
            MostrarDatos_op(pA: 14, pC: 26);
            MostrarDatos_op();

            //Uso de la biblioteca
            r = CMat.suma(5, 3.2);
            Console.WriteLine(r);
            Console.WriteLine("------------------------");

            r = CMat.div(5, 3.2);
            Console.WriteLine(r);
            Console.WriteLine("------------------------");
            Console.Read();
        }

        public static void MostrarDatos(int pA, int pB, int pC)
        {
            Console.WriteLine("El valor de A es {0}", pA);
            Console.WriteLine("El valor de B es {0}", pB);
            Console.WriteLine("El valor de C es {0}", pC);
            Console.WriteLine("------------------------");
        }

        public static void MostrarDatos_op(int pA = 1, int pB = 2, int pC = 3)
        {
            Console.WriteLine("El valor de A es {0}", pA);
            Console.WriteLine("El valor de B es {0}", pB);
            Console.WriteLine("El valor de C es {0}", pC);
            Console.WriteLine("------------------------");
        }
    }
}