using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03_02SobrecargaBinarios
{
    class Program
    {
        static void Main(string[] args)
        {
            CImaginario im1 = new CImaginario(1, 2);
            CImaginario im2 = new CImaginario(3, 4);
            CImaginario imr,imr1,imr2,imr3,imr4;

            //hacemos la suma
            imr = im1 + im2;
            imr1 = im1 + im2 + imr;
            imr2 = imr - im1;
            imr3 = imr * imr1;
            imr4 = imr / imr1;

            Console.WriteLine("{0} + {1} = {2}", im1, im2, imr);
            Console.WriteLine("{0} + {1} + {2} = {3}", im1, im2, imr, imr1);
            Console.WriteLine("{0} - {1} = {2}", imr, im1, imr2);
            Console.WriteLine("{0} * {1} = {2}", imr, im1, imr3);
            Console.WriteLine("{0} / {1} = {2}", imr, im1, imr4);
            Main2();
        }
        static void Main2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("======");
            CImaginario im1 = new CImaginario(1, 2);
            CImaginario im2 = new CImaginario(3, 4);

            Console.WriteLine(im1);
            im1++;
            Console.WriteLine(im1);
            Console.WriteLine("-------");

            Console.WriteLine(im2);
            im2--;
            Console.WriteLine(im2);
            Console.WriteLine("-------");

            Console.WriteLine(im1);
            im1+=im2;
            Console.WriteLine(im1);
            Console.WriteLine("-------");

            main3();
            
        }

        static void main3()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("======");

            CImaginario im1 = new CImaginario(1, 2);
            CImaginario im2 = new CImaginario(3, 4);
            CImaginario im3 = new CImaginario(1, 2);

            if (im1 == im3)
                Console.WriteLine("Son iguales");

            if (im2 != im1)
                Console.WriteLine("Son diferentes");

            Console.Read();
        }
    }
}
