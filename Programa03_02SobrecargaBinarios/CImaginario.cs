namespace Programa03_02SobrecargaBinarios
{
    internal class CImaginario
    {
        private double entero;
        private double imaginario;

        public CImaginario(double pEntero, double pImaginario)
        {
            entero = pEntero;
            imaginario = pImaginario;
        }

        //propiedades
        public double Entero { get { return entero; } set { entero = value; } }

        public double Imaginario { get { return imaginario; } set { imaginario = value; } }

        public override string ToString()
        {
            if (imaginario < 0)
            {
                return string.Format("({0} {1}i)", entero, imaginario);
            }
            else
            {
                return string.Format("({0} + {1}i)", entero, imaginario);
            }
        }

        //Sobrecarga de operadores binarios
        public static CImaginario operator +(CImaginario i1, CImaginario i2)
        {
            double re = i1.entero + i2.entero;
            double ri = i1.imaginario + i2.imaginario;
            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }

        public static CImaginario operator -(CImaginario i1, CImaginario i2)
        {
            double re = i1.entero - i2.entero;
            double ri = i1.imaginario - i2.imaginario;
            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }

        public static CImaginario operator *(CImaginario i1, CImaginario i2)
        {
            double re = i1.entero * i2.entero - i1.imaginario * i2.imaginario;
            double ri = i1.entero * i2.imaginario + i1.imaginario * i2.entero;
            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }

        public static CImaginario operator /(CImaginario i1, CImaginario i2)
        {
            double re = (i1.entero * i2.entero + i1.imaginario * i2.imaginario)
                        / (i2.entero * i2.entero + i2.imaginario * i2.imaginario);

            double ri = (i1.imaginario * i2.entero - i1.entero * i2.imaginario)
                        / (i2.entero * i2.entero + i2.imaginario * i2.imaginario);

            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }

        //Sobrecarga de operadores unuarios
        public static CImaginario operator ++(CImaginario i1)
        {
            CImaginario temp = new CImaginario(i1.entero + 1, i1.imaginario + 1);
            return temp;
        }

        public static CImaginario operator --(CImaginario i1)
        {
            CImaginario temp = new CImaginario(i1.entero - 1, i1.imaginario - 1);
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
                if (imaginario == temp.imaginario && entero == temp.entero)
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
    }
}