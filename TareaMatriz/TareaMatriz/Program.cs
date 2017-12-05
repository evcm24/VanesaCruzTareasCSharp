using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TareaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] matr = {{5,7,6},{5,4,1},{7,9,0}};
            int diagonal=0;

            for (int i = 0; i < 3; i++) 
            {
                diagonal = diagonal + matr[i, i];
                if (i != 1)
                    diagonal = diagonal + matr[i, 2];
            }
            Console.WriteLine("La diagonal es: " + diagonal);
            Console.ReadLine();

        }
    }
}
