using System;

namespace Programa02_05DelegadosRefri
{
    delegate void DReservasBajas(int pkilos);
    delegate void DDescongelado(int pGrados);

 class CRefri
    {
        //Propiedades necesarias
        public int kilosAlimentos { get; set; }

        public int grados { get; set; }

        //Variables que se usan para invocar los delegados
        private DReservasBajas delResevas;
        private DDescongelado delDescongelado;

        //Constructor
        public CRefri(int pKilos, int pGrados)
        {
            kilosAlimentos = pKilos;
            grados = pGrados;
        }

        public void AdicionaMetodoReservas(DReservasBajas pMetodo)
        {
            delResevas += pMetodo; //Adiciona delegados a la lista interna de delReservas
        }

        public void EliminaMetodoReservas(DReservasBajas pMetodo)
        {
            delResevas -= pMetodo; //Elimina delegados a la lista interna de delReservas
        }

        public void AdicionaMetodoDescongelado(DDescongelado pMetodo)
        {
            delDescongelado += pMetodo;
        }

        public void EliminaMetodoDescongelado(DDescongelado pMetodo)
        {
            delDescongelado -= pMetodo;
        }

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
                //Invocacion el metodo
                delResevas(kilosAlimentos);
            }

            if (grados >= 0)
            {
                //Invocacion el metodo
                delDescongelado(grados);
            }
        }
    }
}