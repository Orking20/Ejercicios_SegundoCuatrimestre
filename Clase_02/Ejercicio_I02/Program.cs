using System;

namespace Ejercicio_I02
{
    class Program
    {
        static void Main(string[] args)
        {
            string numIngresadoStr;
            int numIngresado;
            int acumulador = 0;

            do
            {
                Console.WriteLine("Ingrese un número entero: ");
                numIngresadoStr = Console.ReadLine();
                while(!int.TryParse(numIngresadoStr, out numIngresado))
                {
                    Console.WriteLine("Solo puedes ingresar un número entero");
                    Console.WriteLine("Ingrese un número entero nuevamente: ");
                    numIngresadoStr = Console.ReadLine();
                }

                acumulador += numIngresado;

            } while (Validador.ValidarRespuesta());

            Console.WriteLine($"La suma de todos los números ingresados es: {acumulador}");
        }
    }
}
