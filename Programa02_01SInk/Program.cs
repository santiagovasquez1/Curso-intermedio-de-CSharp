using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_01SInk
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear la instancia de la clase
            CRefri refri = new CRefri(50, -20);
            Random rnd = new Random();

            //Creacion del sink
            CRefriSink sink1 = new CRefriSink();

            //Vinculacion de ambos objetos
            refri.AgregarSink(sink1);

            //El refri hace su trabajo
            while (refri.Kilos > 0)
            {
                refri.Trabajar(rnd.Next(1, 5));
            }

            Console.Read();
        }
    }
}
