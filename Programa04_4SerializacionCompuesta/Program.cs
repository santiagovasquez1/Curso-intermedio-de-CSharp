using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Programa04_4SerializacionCompuesta
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int opcion = 0;
            string valor = "";

            Console.WriteLine("1) Crear y serializar el auto, 2) Leer auto");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            if (opcion == 1)
            {
                //Creamos el objeto
                string modelo = "";
                double costo = 0;
                int cilindros = 0;
                int hp = 0;

                Console.WriteLine("Dame el modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Ingresa el costo");
                valor = Console.ReadLine();
                costo = Convert.ToDouble(valor);

                Console.WriteLine("Dame el # de cilindros");
                valor = Console.ReadLine();
                cilindros = Convert.ToInt32(valor);

                Console.WriteLine("Dame los caballos de fuerza");
                valor = Console.ReadLine();
                hp = Convert.ToInt32(valor);

                CAuto auto = new CAuto(modelo, costo);
                auto.CalculaTenencia(0.25);

                CMotor motor = new CMotor 
                {
                    Cilindros=cilindros,
                    Hp=hp
                };

                auto.Motor = motor;

                Console.WriteLine("Auto a serializar");
                auto.Mostrar();

                //Empieza la serializacion
                Console.WriteLine("--Serializando--");

                //Seleccionamos el formateador
                BinaryFormatter formatter = new BinaryFormatter();

                //Se crea el stream
                Stream stream = new FileStream("Auto.aut", FileMode.Create, FileAccess.Write, FileShare.None);

                //Serializamos
                formatter.Serialize(stream, auto);
                stream.Close();
            }

            if (opcion == 2)
            {
                Console.WriteLine("--Deserializando--");
                BinaryFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("Auto.aut", FileMode.Open, FileAccess.Read, FileShare.None);

                CAuto auto = (CAuto)formatter.Deserialize(stream);
                stream.Close();
                Console.WriteLine("El auto es");
                auto.Mostrar();
            }

            Console.Read();
        }
    }
}