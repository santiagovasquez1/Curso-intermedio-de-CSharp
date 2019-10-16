using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_05DelegadosRefri
{
    class CTienda
    {
        public static void MandaViveres(int pkilos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-->Vamos a mandar sus viveres, estoy en la tienda");
            Console.WriteLine("-->Seran {0} kilos", pkilos);
        }
    }
}
