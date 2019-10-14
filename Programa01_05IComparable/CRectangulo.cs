using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_05IComparable
{
    class CRectangulo:IComparable
    {
        private double ancho;
        private double alto;
        private double area;

        public CRectangulo(double pancho, double palto)
        {
            ancho = pancho;
            alto = palto;
            CalculoArea();
        }

        private void CalculoArea()
        {
            area = ancho * alto;
        }

        //Sobrecarga de ToString
        public override string ToString()
        {
            return string.Format("[{0},{1}]={2}", ancho, alto, area);
        }

        //Implementacion de icomparable
        public int CompareTo(object obj)
        {
            //Hacemos type cast con el objeto con el cual nos vamos a comparar
            CRectangulo temp = (CRectangulo)obj;

            if (area > temp.area)
            {
                return 1;
            }
            else if (area < temp.area)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }


    }
}
