using System;

namespace Ejercicio_I06
{
    class Program
    {
        static void Main(string[] args)
        {
            string numIngresadoStr;
            int opcionMenu;
            double longitud;
            double baseTriangulo;
            double altura;
            double radio;

            Console.WriteLine("Calcular:\n1) Área cuadrado\n2) Área triángulo\n3) Área círculo");
            numIngresadoStr = Console.ReadLine();
            while (!int.TryParse(numIngresadoStr, out opcionMenu) || opcionMenu < 1 || opcionMenu > 3)
            {
                Console.WriteLine("Error. Elija un número de las opciones\n1) Área cuadrado\n2) Área triángulo\n3) Área círculo");
                numIngresadoStr = Console.ReadLine();
            }

            switch (opcionMenu)
            {
                case 1:
                    Console.WriteLine("Ingrese la longitud del lado: ");
                    numIngresadoStr = Console.ReadLine();
                    while (!double.TryParse(numIngresadoStr, out longitud))
                    {
                        Console.WriteLine("ERROR. Solo puedes ingresar números\nIngrese la longitud del lado: ");
                        numIngresadoStr = Console.ReadLine();
                    }

                    Console.WriteLine(CalculadoraDeArea.CalcularAreaCuadrado(longitud));
                    break;

                case 2:
                    Console.WriteLine("Ingrese la base del triángulo: ");
                    numIngresadoStr = Console.ReadLine();
                    while (!double.TryParse(numIngresadoStr, out baseTriangulo))
                    {
                        Console.WriteLine("ERROR. Solo puedes ingresar números\nIngrese la base del triángulo: ");
                        numIngresadoStr = Console.ReadLine();
                    }

                    Console.WriteLine("Ingrese la altura del triángulo: ");
                    numIngresadoStr = Console.ReadLine();
                    while (!double.TryParse(numIngresadoStr, out altura))
                    {
                        Console.WriteLine("ERROR. Solo puedes ingresar números\nIngrese la altura del triángulo: ");
                        numIngresadoStr = Console.ReadLine();
                    }

                    Console.WriteLine(CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, altura));
                    break;

                case 3:
                    Console.WriteLine("Ingrese el radio del círculo: ");
                    numIngresadoStr = Console.ReadLine();
                    while (!double.TryParse(numIngresadoStr, out radio))
                    {
                        Console.WriteLine("ERROR. Solo puedes ingresar números\nIngrese el radio del círculo: ");
                        numIngresadoStr = Console.ReadLine();
                    }

                    Console.WriteLine(CalculadoraDeArea.CalcularAreaCirculo(radio));
                    break;
            }


            

        }
    }
}
