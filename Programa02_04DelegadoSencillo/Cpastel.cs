using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_04DelegadoSencillo
{
    class Cpastel
    {
        public static void MostrarPastel(string pAnuncio)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Estamos en la clase pastel");
            Console.WriteLine("El pastel llevara el mensaje de {0}", pAnuncio);
        }

    }
}
