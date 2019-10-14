using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_01SInk
{
    class CRefriSink : IEvenetosRefri
    {
        //Se usan todos los handlers

        public void EReservasBajas(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-->Reservar bajas de alimentos");
            Console.WriteLine("-->Quedan {0} kilos", pKilos);
            
        }
    }
}
