using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TareaTeorema
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 1, z = 0;
            Console.WriteLine("Z\t" + "X\t" + "Y");
            Console.WriteLine("__________________________");
            while(x<20)
            {

               z = (int)Math.Sqrt(x*x+y*y);
               while(y<=50 && z<=50)
           {

             if (z * z == x * x + y * y)
             Console.WriteLine(z+"\t" +x+" \t"+y);
             y = y + 1;
             z = (int)Math.Sqrt(x*x+y*y);
           }
             x=x+1;y=x;

        }
       Console.ReadLine();



        }
    }
}
