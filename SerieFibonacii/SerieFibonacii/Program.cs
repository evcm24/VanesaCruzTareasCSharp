using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerieFibonacii
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, num;
            a = 0;
            b = 1;
            c = 1;
            num = 0;

            Console.WriteLine("Ingresa un valor de la serie");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("El valor de 1 es igual a:" + a);
            Console.WriteLine("El valor de 2 es igual a:" + b);
            Console.WriteLine("El valor de 3 es igual a:" + c);

            for (int i = 4; i <= num; i++)
            {
                a = b;
                b = c;
                c = (a + b);

                Console.WriteLine("El valor de: " + i + "es igual a" + c);

                Console.ReadLine();
            }

        }
    }
}

   