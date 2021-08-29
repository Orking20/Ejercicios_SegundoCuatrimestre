using System;
using System.Text;

namespace Ejercicio_I05
{
    class Program
    {
        static void Main(string[] args)
        {
            string numIngresadoStr;
            int numIngrsado;

            Console.WriteLine("Ingrese un número entero: ");
            numIngresadoStr = Console.ReadLine();
            while (!int.TryParse(numIngresadoStr, out numIngrsado))
            {
                Console.WriteLine("Ingrese un número entero: ");
                numIngresadoStr = Console.ReadLine();
            }

            // COMPLETAR
        }
    }
}
