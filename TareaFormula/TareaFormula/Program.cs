using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TareaFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c,x1,x2,formula;

   Console.WriteLine("Introduce el primer valor");
        a=double.Parse(Console.ReadLine());
   Console.WriteLine("Introducce el segundo valor");
       b=double.Parse(Console.ReadLine());
   Console.WriteLine("Introducir el tercer valor");
       c=double.Parse(Console.ReadLine());

       formula = (c)(b)= 4.0 * a * c;
       if (formula < 0)
       {
           Console.WriteLine("el resultado es:");
           formula = -formula;
       }
       else
           Console.WriteLine("El resultado real es:");
               x1 = (-b + Math.Sqrt(formula))/(2 * a);
               x2 = (-b - Math.Sqrt(formula))/(2 * a);

               Console.WriteLine("X1" + x1);
               Console.WriteLine("X2" + x2);
      Console.ReadLine();

}



 

}

        }
    

