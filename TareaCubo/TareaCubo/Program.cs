using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TareaCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            float area, lado;

            Console.WriteLine("Ingresa el valor");
            lado = float.Parse(Console.ReadLine());
            area = lado * lado;
            Console.WriteLine("El area del cuadrado es:" + area);
            Console.ReadLine();
        }
    }
}
