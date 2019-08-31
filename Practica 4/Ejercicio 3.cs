using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Ejercicio_3
    {
        static void Main(string[] args)
        {
            //Ejercicio 3
            string nombre;
            int[] vocales;
            vocales = new int[5];
            Console.WriteLine("Intruduzca Un Nombre");
            nombre = Console.ReadLine();
            for (int i = 0; i < nombre.Length; i++)
            {
                if ((Convert.ToChar(nombre[i])) == 'a' || (Convert.ToChar(nombre[i])) == 'A' || Convert.ToChar(nombre[i]) == 'á' || Convert.ToChar(nombre[i]) == 'Á')
                {
                    vocales[0] = vocales[0] + 1;
                }
                else
                {
                    if ((Convert.ToChar(nombre[i])) == 'e' || (Convert.ToChar(nombre[i])) == 'E' || Convert.ToChar(nombre[i]) == 'é' || Convert.ToChar(nombre[i]) == 'É')
                    {
                        vocales[1] = vocales[1] + 1;
                    }
                    else
                    {
                        if ((Convert.ToChar(nombre[i])) == 'i' || (Convert.ToChar(nombre[i])) == 'I' || Convert.ToChar(nombre[i]) == 'í' || Convert.ToChar(nombre[i]) == 'Í')
                        {
                            vocales[2] = vocales[2] + 1;
                        }
                        else
                        {
                            if ((Convert.ToChar(nombre[i])) == 'o' || (Convert.ToChar(nombre[i])) == 'O' || Convert.ToChar(nombre[i]) == 'ó' || Convert.ToChar(nombre[i]) == 'Ó')
                            {
                                vocales[3] = vocales[3] + 1;
                            }
                            else
                            {
                                if ((Convert.ToChar(nombre[i])) == 'u' || (Convert.ToChar(nombre[i])) == 'U' || Convert.ToChar(nombre[i]) == 'ú' || Convert.ToChar(nombre[i]) == 'Ú')
                                {
                                    vocales[4] = vocales[4] + 1;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Vocal A: " + vocales[0].ToString("N2"));
            Console.WriteLine("Vocal E: " + vocales[1].ToString("N2"));
            Console.WriteLine("Vocal I: " + vocales[2].ToString("N2"));
            Console.WriteLine("Vocal O: " + vocales[3].ToString("N2"));
            Console.WriteLine("Vocal U: " + vocales[4].ToString("N2"));
            Console.ReadLine();
        }
    }
}
