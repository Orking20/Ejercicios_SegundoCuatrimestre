/* Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.
 * El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
 * Escribir una aplicación que encuentre los 4 primeros números perfectos.*/

using System;

namespace Ejercicio_I04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 2;
            int auxNumero;
            int contador = 5;
            int[] divisores = new int[1000];
            int contadorDivisores;
            int suma;

            while (contador > 0)
            {
                contadorDivisores = 0;
                auxNumero = 0;
                suma = 0;

                for (int j = 0; j < divisores.Length; j++)
                {
                    divisores[j] = 0;
                }

                for (int j = 1; j < numero; j++)
                {
                    if (numero % j == 0)
                    {
                        divisores[contadorDivisores] = j;
                        contadorDivisores++;
                    }
                }

                while(auxNumero < divisores.Length)
                {
                    suma += divisores[auxNumero];

                    auxNumero++;
                }

                if (suma == numero)
                {
                    contador--;
                    Console.WriteLine($"{numero}");
                }

                numero++;
            }
        }
    }
}
