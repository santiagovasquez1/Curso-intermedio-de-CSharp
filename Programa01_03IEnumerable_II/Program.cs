using System;

namespace Programa01_03IEnumerable_II
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CContenedora datos = new CContenedora();

            foreach (int valor in datos)
            {
                Console.WriteLine(valor);
            }

            Console.Read();
        }
    }
}