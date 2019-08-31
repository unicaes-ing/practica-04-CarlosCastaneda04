using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Ejercicio_6
    {
        static void Main(string[] args)
        {
            //Ejercicio 6
            int suc, n, vT = 0;
            double precio = 0, sumSuc = 0, promSuc = 0, sumTotal = 0, promTotal = 0;
            bool rep = false;
            Console.Write("Cantidad de sucursales: ");
            do
            {
                if (int.TryParse(Console.ReadLine(), out suc) && suc > 0)
                {
                    for (int i = 1; i <= suc; i++)
                    {
                        Console.WriteLine("Sucursal #{0}", i);
                        Console.WriteLine("¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬");
                        n = 1;
                        sumSuc = 0;
                        promSuc = 0;
                        do
                        {
                            Console.Write("Venta #{0}: $", n);
                            if (double.TryParse(Console.ReadLine(), out precio) && precio > 0)
                            {
                                sumSuc = sumSuc + precio;
                                n++;
                                vT++;
                            }
                            else
                            {
                                if (precio < 0)
                                {
                                    Console.WriteLine("Tenía que ser un decimal positivo: ");
                                }
                            }
                        } while (precio != 0);
                        promSuc = sumSuc / n;
                        sumTotal = sumTotal + sumSuc;
                        Console.WriteLine("***************************************************************");
                        Console.WriteLine("Ventas Totales: " + sumSuc.ToString("C2"));
                        Console.WriteLine("Promedio de Ventas: " + promSuc.ToString("C2"));
                        Console.WriteLine("***************************************************************");
                    }
                    promTotal = sumTotal / vT;
                    Console.WriteLine("=================================================================");
                    Console.WriteLine("Ventas Totales de Sucursales: " + sumTotal.ToString("C2"));
                    Console.WriteLine("Promedio de Ventas de Sucursales: " + promTotal.ToString("C2"));
                    Console.WriteLine("=================================================================");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Tenía que ser un entero positivo: ");
                    rep = true;
                }
            } while (rep == true);
        }
    }
}
