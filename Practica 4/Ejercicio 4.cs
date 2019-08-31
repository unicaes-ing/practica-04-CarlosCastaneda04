using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Ejercicio_4
    {
        static void Main(string[] args)
        {
            //Ejercicio 4
            double precio = 0, sum = 0, total, bon;
            int num = 1;
            do
            {
                Console.Write("Ventas #{0}: $", num);
                if (double.TryParse(Console.ReadLine(), out precio))
                {
                    if (precio != -1)
                    {
                        sum = sum + precio;
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un decimal");
                    num--;
                }
                num++;
            } while (precio != -1);
            bon = sum * 0.05;
            total = sum + bon;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Ventas totales: " + total.ToString("C2"));
            Console.WriteLine("Bonificación de ventas: " + bon.ToString("C2"));
            Console.ReadKey();
        }
    }
}
