using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo r1 = new Rectangulo();
            Circulo c1 = new Circulo();
            r1.Calcular();
            c1.Realizar();

            Console.ReadLine();
        }
    }
}
