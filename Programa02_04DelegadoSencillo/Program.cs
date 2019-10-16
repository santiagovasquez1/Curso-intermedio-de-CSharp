using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_04DelegadoSencillo
{
    public delegate void MiDelegado(string m); //De esta manera se entiende en todo el namespace
                                               //Si lo uso dentro de la clase, solo esta lo reconoce
    class Program
    {
       
        static void Main(string[] args)
        {
            MiDelegado delegado = new MiDelegado(CRadio.MetodoRadio);
            //Usamo el delegado
            delegado("Hola a todos");
            
            //Hacemos otro apunte a una nueva clase
            delegado = new MiDelegado(Cpastel.MostrarPastel);

            //Ahora invocamos el otro metodo
            delegado("Feliz cumpleaños");

            Console.Read();
        }
    }
}
