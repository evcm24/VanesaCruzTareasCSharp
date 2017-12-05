using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figuras
{
    public class Circulo
    {
        public double PI = 3.1416;
        public double Area {get; set;}
        public double Radio{get; set;}

        public void  Realizar()
        {
            Console.WriteLine("Introduce el radio");
            Radio = double.Parse(Console.ReadLine());
            Area = PI * Math.Pow(Radio, 2);
            Console.WriteLine(Area); 
        }
       

       


    }
}