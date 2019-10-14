using System;
using System.Collections;

namespace Programa02_01SInk
{
    internal class CRefri
    {
        private ArrayList ListaSinks = new ArrayList(); //Arreglo dinamico

        private int kilosAlimentos;
        private int grados;

        public CRefri(int pkilos, int pgrados)
        {
            kilosAlimentos = pkilos;
            grados = pgrados;
        }

        //Metodo para adicionar una clase sink
        public void AgregarSink(IEvenetosRefri psink) //Recive un objeto que use la interfaz
        {
            if (psink != null)
                ListaSinks.Add(psink);
        }

        public void EliminarSink(IEvenetosRefri psink)
        {
            if (ListaSinks.Contains(psink) == true)
                ListaSinks.Remove(psink);
        }

        //Propiedades de la clase
        public int Kilos { get { return kilosAlimentos; } }

        public int Grados { get { return grados; } }

        public void Trabajar(int pconsumo)
        {
            //Actualizamos los kilos en el refri
            kilosAlimentos -= pconsumo;

            //Subir temperatura
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos, {1} grados", kilosAlimentos, grados);

            //Verificacion de condiciones para accionar eventes

            if (kilosAlimentos < 10)
            {
                //Invocacion a los handlers de cada sink
                foreach (IEvenetosRefri Handler in ListaSinks)
                {
                    Handler.EReservasBajas(kilosAlimentos);
                }
            }

            if (Grados >= 0)
            {
                //Invocacion a los handlers de cada sink
                foreach (IEvenetosRefri Handler in ListaSinks)
                {
                    Handler.Edescongelado(grados);
                }
            }
        }
    }
}