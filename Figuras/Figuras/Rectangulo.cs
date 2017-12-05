using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figuras
{
    public class Rectangulo
    {
        public float Base { get; set; }
        public float Altura { get; set; }
        public float Resultado { get; set; }

        public void Calcular()
        {
            Console.WriteLine("Introduce la altura");
            Base = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la base");
            Altura= float.Parse(Console.ReadLine());
            Resultado = Base * Altura;
            Console.WriteLine(Resultado);
        }
    }
}
