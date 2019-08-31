using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Ejercicio_2
    {
        static void Main(string[] args)
        {
            //Ejercicio 2
            decimal nota = 0;
            int asis = 0, alum = 0, apro = 0, repr = 0;
            bool rep = true;
            Console.WriteLine("Registro de Módulo Programación Estructurada");
            Console.WriteLine();
            Console.Write("Cantidad de alumnos: ");
            do
            {
                if (int.TryParse(Console.ReadLine(), out alum) && alum >= 0)
                {
                    rep = false;
                }
                else
                {
                    Console.WriteLine("Tenía que se un entero positivo :(");
                }
            } while (rep == true);
            Console.WriteLine("*****************************************************");
            for (int n = 1; n <= alum; n++)
            {
                Console.Write("Nota del Alumno " + n + ": ");
                do
                {
                    if (decimal.TryParse(Console.ReadLine(), out nota) && (nota >= 0 && nota <= 10))
                    {
                        rep = false;
                    }
                    else
                    {
                        Console.WriteLine("El valor tiene que ser un decimal entre 0 y 10 :(");
                        rep = true;
                    }
                } while (rep == true);
                Console.WriteLine("Asistencia del Alumno " + n + " (%): ");
                do
                {
                    if (int.TryParse(Console.ReadLine(), out asis) && (asis >= 0 && asis <= 100))
                    {
                        rep = false;
                    }
                    else
                    {
                        Console.WriteLine("El valor tiene que ser un decimal entre 0 y 100 :(");
                        rep = true;
                    }
                } while (rep == true);
                Console.WriteLine("********************************************************");
                if (nota >= 7 && asis >= 75)
                {
                    apro++;
                }
                else
                {
                    repr++;
                }
            }
            Console.WriteLine("Alumnos Aprobados: " + apro.ToString("N2"));
            Console.WriteLine("Alumnos Reprobados: " + repr.ToString("N2"));
            Console.ReadKey();
        }
    }
}
