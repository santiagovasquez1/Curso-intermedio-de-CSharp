﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_03IEnumerable_II
{
    class Program
    {
        static void Main(string[] args)
        {
            CContenedora datos = new CContenedora();

            foreach(int valor in datos)
            {
                Console.WriteLine(valor);
            }

            Console.Read();
        }
    }
}
