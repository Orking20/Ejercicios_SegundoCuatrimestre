/* Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
 * Validar que el dato ingresado por el usuario sea un número.
 * Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
 * Si ingresa "salir", cerrar la consola.
 * Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.*/

using System;

namespace Ejercicio_I03
{
    class Program
    {
        static void Main(string[] args)
        {
            string numIngresadoStr;
            int numIngresado;
            int contador;
            string respuesta;

            do
            {
                Console.Write("Ingrese un número: ");
                numIngresadoStr = Console.ReadLine();

                while (!int.TryParse(numIngresadoStr, out numIngresado))
                {
                    Console.Write("ERROR. ¡Reingrese un número! ");
                    numIngresadoStr = Console.ReadLine();

                    if (numIngresadoStr == "salir")
                    {
                        Environment.Exit(0);
                    }
                }

                for (int i = numIngresado; i > 0; i--)
                {
                    contador = 0;

                    for (int j = i; j > 0; j--)
                    {
                        if (i % j == 0)
                        {
                            contador++;
                        }
                    }

                    if (contador == 2)
                    {
                        Console.WriteLine($"{i}");
                    }
                }

                Console.Write("¿Desea volver a operar? (si/no) ");
                respuesta = Console.ReadLine();
                while(respuesta != "si" && respuesta != "no")
                {
                    Console.Write("ERROR. ¿Desea volver a operar? (si/no) ");
                    respuesta = Console.ReadLine();
                }

                if(respuesta == "no")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                }

            } while (respuesta == "si");
        }
    }
}
