using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            CTienda tienda = new CTienda();

            //Recorremos cada uno de los elementos de la estructura

            foreach(CAuto auto in tienda)
            {
                auto.CalculaTenencia(0.05);
                auto.Mostrar();
            }

            Main2();
        }

        static void Main2()
        {
            Console.WriteLine("Inicio de main 2");
            CAuto auto1 = new CAuto("March", 17000);

            ////Supuesta clonacion
            //CAuto auto2 = auto1;

            //Verdadera clonacion
            CAuto auto2 = (CAuto)auto1.Clone();

            auto1.CalculaTenencia(0.1);
            auto2.CalculaTenencia(0.1);

            //Impresion
            auto1.Mostrar();
            auto2.Mostrar();

            Console.WriteLine("---------");

            //Hacemos un cambio, si fuera clon solo cambia uno
            auto2.Costo = 60000;
            auto2.CalculaTenencia(0.05);

            //Impresion
            auto1.Mostrar();
            auto2.Mostrar();

            Console.WriteLine("---------");
            Console.Read();
        }
    }
}
