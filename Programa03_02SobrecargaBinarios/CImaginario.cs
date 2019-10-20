using System;

namespace Programa03_02SobrecargaBinarios
{
    internal class CImaginario:IComparable
    {
        public CImaginario(double pEntero, double pImaginario)
        {
            Entero = pEntero;
            Imaginario = pImaginario;
        }

        //propiedades
        public double Entero { get; set; }

        public double Imaginario { get; set; }

        public double magnitud()
        {
            double m = Math.Sqrt(Math.Pow(Entero, 2) + Math.Pow(Imaginario, 2));
            return m;
        }

        public override string ToString()
        {
            if (Imaginario < 0)
            {
                return string.Format("({0} {1}i)", Entero, Imaginario);
            }
            else
            {
                return string.Format("({0} + {1}i)", Entero, Imaginario);
            }
        }

        //Sobrecarga de operadores binarios
        public static CImaginario operator +(CImaginario i1, CImaginario i2)
        {
            double re = i1.Entero + i2.Entero;
            double ri = i1.Imaginario + i2.Imaginario;
            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }

        public static CImaginario operator -(CImaginario i1, CImaginario i2)
        {
            double re = i1.Entero - i2.Entero;
            double ri = i1.Imaginario - i2.Imaginario;
            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }

        public static CImaginario operator *(CImaginario i1, CImaginario i2)
        {
            double re = i1.Entero * i2.Entero - i1.Imaginario * i2.Imaginario;
            double ri = i1.Entero * i2.Imaginario + i1.Imaginario * i2.Entero;
            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }

        public static CImaginario operator /(CImaginario i1, CImaginario i2)
        {
            double re = (i1.Entero * i2.Entero + i1.Imaginario * i2.Imaginario)
                        / (i2.Entero * i2.Entero + i2.Imaginario * i2.Imaginario);

            double ri = (i1.Imaginario * i2.Entero - i1.Entero * i2.Imaginario)
                        / (i2.Entero * i2.Entero + i2.Imaginario * i2.Imaginario);

            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }

        //Sobrecarga de operadores unuarios
        public static CImaginario operator ++(CImaginario i1)
        {
            CImaginario temp = new CImaginario(i1.Entero + 1, i1.Imaginario + 1);
            return temp;
        }

        public static CImaginario operator --(CImaginario i1)
        {
            CImaginario temp = new CImaginario(i1.Entero - 1, i1.Imaginario - 1);
            return temp;
        }

        //Sobrecarga de operador de igualdad y desigualdad

        public override bool Equals(object obj)
        {
            //Verificacion de que el tipo sea el correcto
            if (obj is CImaginario)
            {
                CImaginario temp = (CImaginario)obj;

                //Comparamos la igualdad
                if (Imaginario == temp.Imaginario && Entero == temp.Entero)
                    return true;
            }

            return false;
        }

        public static bool operator ==(CImaginario i1, CImaginario i2)
        {
            return i1.Equals(i2);
        }

        public static bool operator !=(CImaginario i1, CImaginario i2)
        {
            return !i1.Equals(i2); //Negacion de equals
        }
        
        public int CompareTo(object obj)
        {
           if (obj is CImaginario)
            {
                CImaginario temp = (CImaginario)obj;
                if (magnitud() > temp.magnitud()) return 1;
                if (magnitud() < temp.magnitud()) return -1;
            }

            return 0;
        }

        public static bool operator<(CImaginario i1,CImaginario i2)
        {
            if (i1.CompareTo(i2) < 0)
                return true;
            else
                return false;
        }

        public static bool operator >(CImaginario i1, CImaginario i2)
        {
            if (i1.CompareTo(i2) > 0)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}