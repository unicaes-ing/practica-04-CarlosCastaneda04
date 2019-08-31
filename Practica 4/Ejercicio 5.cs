using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Ejercicio_5
    {
        static void Main(string[] args)
        {
            //Ejercicio 5
            string contra = "mon1234", comp;
            int intentos = 0;
            bool rep = true;
            Console.WriteLine("¡Bienvenido!");
            Console.WriteLine("Ingrese su contraseña");
            do
            {
                intentos++;
                if (intentos == 2)
                {
                    Console.WriteLine("La primera letra de su contraseña es \"m\" ");
                }
                else
                {
                    if (intentos == 3)
                    {
                        Console.WriteLine("La primera letra de su contraseña es \"m\" ");
                    }
                }
                comp = Console.ReadLine();
                if (comp == contra)
                {
                    Console.WriteLine("La contraseña es correcta");
                    Console.WriteLine("Ya puede acceder...");
                    rep = false;
                }
                else
                {
                    Console.WriteLine("Contraseña Incorrecta, Intentos restantes: " + (3 - intentos));
                }
            } while (rep == true && intentos != 3);
            if (intentos == 3)
            {
                Console.WriteLine("Intentos terminados, inténtelo más tarde...");
            }
            Console.ReadKey();
        }
    }
}
