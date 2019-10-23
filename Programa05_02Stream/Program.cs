using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa05_02Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            long Cantidad = 0;
            long n = 0;
            int valor = 0;

            FileStream fs = new FileStream("Datos.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            Cantidad = fs.Length; //Cantidad;
            Console.WriteLine("El archivo mide {0}", Cantidad);

            //Leemos byte por byte

            for (n = 0; n < Cantidad; n++)
            {
                fs.Seek(n, SeekOrigin.Begin);
                valor = fs.ReadByte();
                Console.Write("{0}{1}{2} ","\t",(char)valor,"\t");

            }
            fs.Close();
            Console.Read();
        }
    }
}
