    using System;

namespace Ejercicio_I04
{
    class Program
    {
        static void Main(string[] args)
        {
            string numIngresadoStr;
            string operador;
            double num1;
            double num2;

            Console.WriteLine("Calculadora\n");

            do
            {
                Console.Write("Ingrese el primer operando: ");
                numIngresadoStr = Console.ReadLine();
                while (!double.TryParse(numIngresadoStr, out num1))
                {
                    Console.WriteLine("ERROR. Solo puede ingresar números");
                    Console.Write("Ingrese el primer operando: ");
                    numIngresadoStr = Console.ReadLine();
                }

                Console.Write("Ingrese el segundo operando: ");
                numIngresadoStr = Console.ReadLine();
                while (!double.TryParse(numIngresadoStr, out num2))
                {
                    Console.WriteLine("ERROR. Solo puede ingresar números");
                    Console.Write("Ingrese el segundo operando: ");
                    numIngresadoStr = Console.ReadLine();
                }

                Console.Write("Ingrese el operador (+ - * /): ");
                operador = Console.ReadLine();

                if(operador == "/" && num2 == 0)
                {
                    Console.WriteLine("No se puede dividir un número por 0");
                }
                else
                {
                    Console.WriteLine(Calculadora.Calcular(num1, num2, operador));
                }

            } while (Validador.ValidarRespuesta());
        }
    }
}
