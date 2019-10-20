using System;

namespace Programa05_3SerializacionXML
{
    [Serializable]
    public class CAuto : IAutomovil
    {
        private double costo;
        private double tenencia;
        private string modelo;

        //propiedades
        public double Costo { get { return costo; } set { costo = value; } }

        public string Modelo { get { return modelo; } set { modelo = value; } }
        public double Tenencia { get { return tenencia; } set { tenencia = value; } }

        //Constructor sin parametros para xml
        public CAuto()
        {
            costo = 18 * Math.Pow(10, 6);
            modelo = "Corsa";
        }

        //Metodos de la interfaz
        public void CalculaTenencia(double imp)
        {
            tenencia = 5000 + costo * imp;
        }

        public void Mostrar()
        {
            Console.WriteLine("Tu automovil {0}", modelo);
            Console.WriteLine("Costo {0}, con una tenencia de {1}", costo, tenencia);
            Console.WriteLine("Total {0}", costo + tenencia);
            Console.WriteLine("-----");
        }
    }
}