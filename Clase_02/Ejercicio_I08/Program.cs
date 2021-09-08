using System;

namespace Ejercicio_I08
{
    class Program
    {
        static void Main(string[] args)
        {
            string numIngresadoStr;
            int dia;
            int mes;
            int anio;
            DateTime fechaActual = DateTime.Today;
            DateTime fecha;

            Console.WriteLine("Ingrese su fecha de nacimiento:");

            Console.WriteLine("Número de día: ");
            while (!int.TryParse(Console.ReadLine(), out dia) || dia < 1 || dia > 31)
            {
                Console.WriteLine("ERROR. Ingrese un número entre el 1 y el 31\nIngrese el número de su día de nacimiento: ");
            }

            Console.WriteLine("Número de mes: ");
            while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12)
            {
                Console.WriteLine("ERROR. Ingrese un número entre el 1 y el 12\nIngrese el número de su mes de nacimiento: ");
            }

            Console.WriteLine("Número de año: ");
            while (!int.TryParse(Console.ReadLine(), out anio) || anio < 1 || anio > fechaActual.Year)
            {
                Console.WriteLine("ERROR. Ingrese un número entre el 1 y el año actual\nIngrese el número de su año de nacimiento: ");
            }

            fecha = new DateTime(anio, mes, dia);

            Console.WriteLine(fechaActual.Subtract(fecha).Days);
        }
    }
}
