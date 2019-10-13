using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_02
{
    class CTienda
    {
        private CAuto[] disponibles;

        public CTienda()
        {
            disponibles = new CAuto[4];
            disponibles[0] = new CAuto("Soul", 220000.50);
            disponibles[1] = new CAuto("Fit", 160000.50);
            disponibles[2] = new CAuto("March", 180000.50);
            disponibles[3] = new CAuto("Spark", 150000.50);
        }

        public IEnumerator GetEnumerator()
        {
            return disponibles.GetEnumerator();
        }

    }
}
