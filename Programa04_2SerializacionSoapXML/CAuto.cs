using System;


namespace Programa04_2SerializacionSoapXML
{
    [Serializable]
    internal class CAuto : IAutomovil, ICloneable
    {
        private double costo;
        private double tenencia;
        private string modelo;

        //propiedades
        public double Costo { get { return costo; } set { costo = value; } }

        public double Tenencia { get { return tenencia; } set { tenencia = value; } }

        //Constructor
        public CAuto(string _modelo, double _costo)
        {
            costo = _costo;
            modelo = _modelo;
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

        public object Clone()
        {
            CAuto temp = new CAuto(modelo, costo);
            temp.Tenencia = tenencia;
            return temp;
        }
    }
}