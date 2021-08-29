/* Escribir un programa que determine si un año es bisiesto.
 * Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400.
 * Por ejemplo: el año 2000 es bisiesto pero 1900 no.
 * Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.*/

using System;

namespace Ejercicio_I06
{
    class Program
    {
        static void Main(string[] args)
        {
            string anioInicialStr;
            string anioFinalStr;
            int anioInicial;
            int anioFinal;

            Console.Write("Ingrese un año: ");
            anioInicialStr = Console.ReadLine();
            while(!int.TryParse(anioInicialStr, out anioInicial) || anioInicial < 0)
            {
                Console.Write("ERROR. Ingrese un año: ");
                anioInicialStr = Console.ReadLine();
            }

            Console.Write("Ingrese un año más grande: ");
            anioFinalStr = Console.ReadLine();
            while (!int.TryParse(anioFinalStr, out anioFinal) || anioFinal < 0)
            {
                Console.Write("ERROR. Ingrese un año: ");
                anioFinalStr = Console.ReadLine();
            }

            Console.WriteLine($"Años biciestos entre el {anioInicial} y el {anioFinal}");

            for (int i = anioInicial; i < anioFinal; i++)
            {
                if (i % 4 == 0)
                {
                    if (i % 100 == 0 && i % 400 != 0)
                    {
                        continue;
                    }

                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
