using System;
using System.Collections.Generic;
using System.Linq;

namespace Programa01_05IComparable
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CRectangulo[] rectangulos = new CRectangulo[5];
            List<CRectangulo> Rectangulos2 = new List<CRectangulo>();

            rectangulos[0] = new CRectangulo(7, 5);
            rectangulos[1] = new CRectangulo(6, 4);
            rectangulos[2] = new CRectangulo(4, 3);
            rectangulos[3] = new CRectangulo(7, 6);
            rectangulos[4] = new CRectangulo(5, 7);

            Rectangulos2 = rectangulos.ToList();

            //Impresion arreglo original
            foreach (CRectangulo rectangulo in rectangulos)
                Console.WriteLine(rectangulo);

            Console.WriteLine("===========");

            //Hacemos uso del sortm el cual necesita la implementacion de icomparable
            Array.Sort(rectangulos);

            //Impresion del rectangulo ordenado
            foreach (CRectangulo rectangulo in rectangulos)
                Console.WriteLine(rectangulo);
            Console.WriteLine("===========");

            Rectangulos2.Sort();
            foreach (CRectangulo rectangulo in Rectangulos2)
                Console.WriteLine(rectangulo);
            Console.Read();
        }
    }
}