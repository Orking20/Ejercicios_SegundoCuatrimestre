using System;

namespace NumerosLocos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arrayNumeros = new int[20];

            //Genera los números aleatorios y los muestra
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                arrayNumeros[i] = random.Next(-100, 100);
                while (arrayNumeros[i] == 0)
                {
                    arrayNumeros[i] = random.Next(-100, 100);
                }

                Console.WriteLine($"{i + 1}: {arrayNumeros[i]}");
            }

            Console.WriteLine("\nPositivos en forma decreciente:");
            Array.Sort(arrayNumeros);
            Array.Reverse(arrayNumeros);
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                if (arrayNumeros[i] > 0)
                {
                    Console.WriteLine(arrayNumeros[i]);
                }
            }

            Console.WriteLine("\nNegativos en forma creciente:");
            Array.Sort(arrayNumeros);
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                if (arrayNumeros[i] < 0)
                {
                    Console.WriteLine(arrayNumeros[i]);
                }
            }
        }
    }
}
