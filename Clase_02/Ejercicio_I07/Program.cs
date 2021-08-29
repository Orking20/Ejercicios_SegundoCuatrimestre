using System;

namespace Ejercicio_I07
{
    class Program
    {
        static void Main(string[] args)
        {
            string numIngresadoStr;
            double baseTriangulo;
            double altura;
            double longitudHipotenusa;

            Console.Write("Ingrese la base de un triángulo en cm: ");
            numIngresadoStr = Console.ReadLine();
            while (!double.TryParse(numIngresadoStr, out baseTriangulo))
            {
                Console.Write("ERROR. Solo puedes ingresar números\nIngrese la base de un triángulo en cm: ");
                numIngresadoStr = Console.ReadLine();
            }

            Console.Write("Ingrese la altura de un triángulo en cm: ");
            numIngresadoStr = Console.ReadLine();
            while (!double.TryParse(numIngresadoStr, out altura))
            {
                Console.Write("ERROR. Solo puedes ingresar números\nIngrese la altura de un triángulo en cm: ");
                numIngresadoStr = Console.ReadLine();
            }

            longitudHipotenusa = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(altura, 2));

            Console.WriteLine($"Longitud de la hipotenusa: {longitudHipotenusa}");
        }
    }
}
