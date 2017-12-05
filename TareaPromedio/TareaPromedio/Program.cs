using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TareaPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
             int alum=0;
             double nota=0;
             double prom=0;

          Console.WriteLine ("La nota de cuantos alumnos evaluara");
           alum=int.Parse(Console.ReadLine());
   
         for(int i =0;i<=alum;i++){
         Console.WriteLine ("Digite nota para el alumno: "+(i+1)); 
    nota=double.Parse(Console.ReadLine());
    prom=prom+nota;
    
    
    
   }
   Console.WriteLine ("El promedio es : "+(prom/alum));
   
   
   Console.ReadLine();
  }
 }
}
        
    

