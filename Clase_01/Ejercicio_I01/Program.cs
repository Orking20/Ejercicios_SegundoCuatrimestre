/* Ingresar 5 números por consola, guardándolos en una variable escalar.
 * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.*/

using System;

namespace Ejercicio_I01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numIngresado;
            int acumulador = 0;
            int minimo = 0;
            int maximo = 0;
            double promedio;

            for (int i = 0; i < 5; i++)
            {
                numIngresado = int.Parse(Console.ReadLine());
                acumulador += numIngresado;

                if (i == 0)
                {
                    minimo = numIngresado;
                    maximo = numIngresado;
                }
                else
                {
                    if (numIngresado < minimo)
                    {
                        minimo = numIngresado;
                    }
                    if (numIngresado > maximo)
                    {
                        maximo = numIngresado;
                    }
                }
            }

            promedio = (double)acumulador / 5;

            Console.WriteLine($"Número mínimo: {minimo}");
            Console.WriteLine($"Número máximo: {maximo}");
            Console.WriteLine($"Promedio: {promedio}");
        }
    }
}
