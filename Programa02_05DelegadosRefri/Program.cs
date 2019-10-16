using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_05DelegadosRefri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear la instancia de la clase
            CRefri refri = new CRefri(70, -20);
            Random rnd = new Random();

            //Variables para el multicasting
            DReservasBajas kilos1 = new DReservasBajas(Informekilos);
            DReservasBajas kilos2 = new DReservasBajas(CTienda.MandaViveres);
            DDescongelado descongelado1 = new DDescongelado(InformeGrados);

            //Adicionamos los handlers
            refri.AdicionaMetodoReservas(kilos1);
            refri.AdicionaMetodoReservas(kilos2);
            refri.AdicionaMetodoDescongelado(descongelado1);

            //Trabajo clase
            while (refri.kilosAlimentos > 0)
            {
                refri.Trabajar(rnd.Next(1, 5));
            }

            //Eliminamos un handler
            refri.EliminaMetodoReservas(kilos2);

            //Rellenamos el refri
            refri.kilosAlimentos = 50;
            refri.grados = -15;

            while (refri.kilosAlimentos > 0)
            {
                refri.Trabajar(rnd.Next(1, 5));
            }

            Console.Read();

        }

        public static void Informekilos(int pkilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-->Reservar bajas de alimentos, estamos a nivel de main");
            Console.WriteLine("-->Quedan {0} kilos", pkilos);
        }

        public static void InformeGrados(int pgrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-->El refri se descongela, estamos a nivel de main");
            Console.WriteLine("--> Esta a {0} grados", pgrados);

        }
    }
}
