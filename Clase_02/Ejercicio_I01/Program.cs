using System;

namespace Ejercicio_I01
{
    class Program
    {
        static void Main(string[] args)
        {
            string numIngresadoStr;
            int numIngresado;
            int minimo = 0;
            int maximo = 0;
            int acumulador = 0;
            double promedio;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número entero entre el -100 y 100: ");
                numIngresadoStr = Console.ReadLine();
                while (!int.TryParse(numIngresadoStr, out numIngresado) || numIngresado < -100 || numIngresado > 100)
                {
                    Console.WriteLine("ERROR. Solo puedes ingresar un número entero entre el -100 y el 100");
                    Console.WriteLine("Ingrese un número nuevamente: ");
                    numIngresadoStr = Console.ReadLine();
                }

                if (i == 0 || numIngresado < minimo)
                {
                    minimo = numIngresado;
                }
                if (i == 0 || numIngresado > maximo)
                {
                    maximo = numIngresado;
                }

                acumulador += numIngresado;
            }

            promedio = (double)acumulador / 10;

            Console.WriteLine($"Valor mínimo: {minimo}\nValor máximo: {maximo}\nPromedio: {promedio}");
        }
    }
}
