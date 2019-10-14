using System;
using System.Collections;

namespace Programa01_03IEnumerable_II
{
    internal class CContenedora : IEnumerable
    {
        private int[] Valores = new int[10];

        public CContenedora()
        {
            for (int i = 0; i < 10; i++)
                Valores[i] = i * i;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ContenedorEnum(Valores);
            throw new NotImplementedException();
        }
    }

    internal class ContenedorEnum : IEnumerator  //Clase enumerator de nuestra estructura de datos
    {
        public int[] arreglo;
        private int posicion = -1;

        public ContenedorEnum(int[] pArreglo)
        {
            arreglo = pArreglo;
        }

        public object Current //Hacer uso de exepciones
        {
            get
            {
                return arreglo[posicion];
            }
        }

        public bool MoveNext()
        {
            posicion++;
            if (posicion < arreglo.Length)
                return true;
            else
                return false;
        }

        public void Reset() //Reestrablecer el inicio
        {
            posicion = -1;
        }
    }
}