using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa04_4SerializacionCompuesta
{
    [Serializable]//Modifidador
    class CMotor
    {
        public int Cilindros { get; set; }
        public int Hp { get; set; }
        public void mostrar()
        {
            Console.WriteLine("===> Cilindros: {0}, HP: {1}", Cilindros, Hp);
        }

    }
}
