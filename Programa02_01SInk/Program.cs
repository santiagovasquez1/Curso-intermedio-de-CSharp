using System;

namespace Programa02_01SInk
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Crear la instancia de la clase
            CRefri refri = new CRefri(60, -20);
            Random rnd = new Random();

            //Creacion del sink
            CRefriSink sink1 = new CRefriSink();
            CTiendaSink tiendaSink = new CTiendaSink();

            //Vinculacion de ambos objetos
            refri.AgregarSink(sink1);
            refri.AgregarSink(tiendaSink);

            //El refri hace su trabajo
            while (refri.Kilos > 0 && sink1.paro==false)
            {
                refri.Trabajar(rnd.Next(1, 5));
            }

            Console.Read();
        }
    }
}