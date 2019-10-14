using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_01SInk
{
    class CTiendaSink : IEvenetosRefri
    {
        public void EReservasBajas(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-->Le enviaremos sus viveres");
            Console.WriteLine("-->Seran {0} kilos", pKilos);
        }

        public void Edescongelado(int pgrados)
        {
            //Handler vacio
        }
    }
}
