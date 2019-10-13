using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion=0;
            double val_a, Val_b;
            string valor = "";

            Ioperaciones operacion = new CSuma();

            while (opcion != 5)
            {
                Console.WriteLine("1-Suma,2-Resta,3-Multi,4-Div");
                Console.WriteLine("Que opcion deseas?");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                Console.WriteLine("Dame el valor de a: ");
                valor = Console.ReadLine();
                val_a = Convert.ToDouble(valor);

                Console.WriteLine("Dame el valor de b: ");
                valor = Console.ReadLine();
                Val_b = Convert.ToDouble(valor);

                //Poliformismo
                if (opcion == 1) operacion = new CSuma();
                if (opcion == 2) operacion = new CResta();
                if (opcion == 3) operacion = new CMulti();
                if (opcion == 4) operacion = new CDiv();

                operacion.Calcular(val_a, Val_b);
                operacion.Mostrar();
            }
        }
    }
}
