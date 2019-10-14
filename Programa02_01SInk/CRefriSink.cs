using System;

namespace Programa02_01SInk
{
    internal class CRefriSink : IEvenetosRefri
    {
        public bool paro { get; set; } = false;

        //Se usan todos los handlers

        public void EReservasBajas(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-->Reservar bajas de alimentos");
            Console.WriteLine("-->Quedan {0} kilos", pKilos);
        }

        public void Edescongelado(int pgrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-->El refri se descongela");
            if (pgrados > 0) paro = true;
        }

    }
}