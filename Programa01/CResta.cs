﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01
{
    class CResta : Ioperaciones
    {
        private double r = 0;
        public void Mostrar()
        {
            Console.WriteLine("El resultado de la resta es {0}", r);
        }

        public void Calcular(double a, double b)
        {
            r = a - b;
        }
    }
}