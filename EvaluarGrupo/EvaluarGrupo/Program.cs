﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvaluarGrupo
{
    class Program
    {
        static void Main(string[] args)
        {
            int alumnos, nCal = 0;
            float res = 0;
            string grupo;
            Console.WriteLine("Ingresa el numero de alumnos: ");
            alumnos = int.Parse(Console.ReadLine());

            int[] calificaciones = RegistrarCalificaciones(alumnos);
            Evaluar(calificaciones);

            res /= alumnos;

            if (res >= 9)
                grupo = "es un excelente grupo";
            else if (res >= 7)
                grupo = "es un buen grupo";
            else
                grupo = "es un mal grupo";

            Console.WriteLine("\n El promedio total es: {0} \n se considera un {1}", res, grupo);

            Console.ReadKey();
         }

        static int[] RegistrarCalificaciones(int numeroCalificaciones)
        {
            int[] cAlum = new int[numeroCalificaciones];
            int nCal = 0;
            do
            {
                Console.WriteLine("inserte calificaion del alumno {0}", (nCal + 1));
                cAlum[nCal] = int.Parse(Console.ReadLine());
                nCal++;
            } while (nCal < numeroCalificaciones);

                return cAlum;
        }

        static void Evaluar(int[] alumnos)
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                if (alumnos[i] >= 9)
                    Console.WriteLine("\nel alumno {i + 1} es un excelente alumno");
                else if (alumnos[i] >= 7)
                    Console.WriteLine("\nel alumno {i + 1} es un buen alumno");
                else
                    Console.WriteLine("\nel alumno {i + 1} es un mal alumno");
            }
        }

     }
 }
        
    

