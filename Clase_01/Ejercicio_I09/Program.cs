/* Escribir un programa que imprima por consola un cono*/

using System;

namespace Ejercicio_I09
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            string numIngresadoStr;
            int numIngresado;

            Console.WriteLine("Ingrese la altura del triángulo: ");
            numIngresadoStr = Console.ReadLine();
            while (!int.TryParse(numIngresadoStr, out numIngresado))
            {
                Console.WriteLine("ERROR. Solo puede ingresar números enteros");
                Console.WriteLine("Ingrese la altura del triángulo: ");
                numIngresadoStr = Console.ReadLine();
            }

            for (int i = 0; i < numIngresado; i++)
            {
                for (int j = 5; j > contador; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < contador; j++)
                {
                    Console.Write("*");

                    if (j == 0)
                    {
                        for (int k = 0; k < contador; k++)
                        {
                            Console.Write("*");
                        }
                    }
                }

                Console.WriteLine("*");

                contador++;
            }
        }
    }
}
