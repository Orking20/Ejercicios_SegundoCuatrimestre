/* Ingresar un número y mostrar el cuadrado y el cubo del mismo.
 * Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".*/

using System;

namespace Ejercicio_I02
{
    class Program
    {
        static void Main(string[] args)
        {
            string numIngresadoStr;
            int numIngresado;
            double cuadrado;
            double cubo;

            Console.Write("Ingrese un número: ");
            numIngresadoStr = Console.ReadLine();

            while(!int.TryParse(numIngresadoStr, out numIngresado) || numIngresado <= 0)
            {
                Console.Write("ERROR. ¡Reingresar número! ");
                numIngresadoStr = Console.ReadLine();
            }

            cuadrado = Math.Pow(numIngresado, 2);
            cubo = Math.Pow(numIngresado, 3);

            Console.WriteLine($"El cuadrado de {numIngresado} es {cuadrado}");
            Console.WriteLine($"El cubo de {numIngresado} es {cubo}");
        }
    }
}
