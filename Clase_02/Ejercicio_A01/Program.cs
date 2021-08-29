using System;

namespace Ejercicio_A01
{
    class Program
    {
        static void Main(string[] args)
        {
            string numIngresadoStr;
            int numIngresado;

            Console.Write("Ingrese un número entero para ver su factorial: ");
            numIngresadoStr = Console.ReadLine();
            while (!int.TryParse(numIngresadoStr, out numIngresado))
            {
                Console.Write("ERROR. Solo puedes ingresar números enteros\nIngrese un número entero para ver su factorial: ");
                numIngresadoStr = Console.ReadLine();
            }

            Console.WriteLine(Factorial(numIngresado));
        }

        static int Factorial(int numero)
        {
            int retorno;

            retorno = numero;

            for (int i = 1; i < numero; i++)
            {
                retorno *= i;
            }

            return retorno;
        }
    }
}
