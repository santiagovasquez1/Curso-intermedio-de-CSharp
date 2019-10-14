using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_04DelegadoSencillo
{
    class CRadio
    {
        public static void MetodoRadio(string pMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Estamos en la clase radio");
            Console.WriteLine("Este es tu mensaje {0}", pMensaje);
        }
    }
}
