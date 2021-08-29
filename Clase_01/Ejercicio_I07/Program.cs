/* Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.
 * Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas),
 * hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
 * Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.*/

using System;

namespace Ejercicio_I07
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            string numIngresadoStr;
            double valorHora;
            string nombre;
            double antiguedad;
            double horasTrabajadasAlMes;
            double importe;
            double importeConAntiguedad;
            double descuento;
            double importeTotal;
            int contador = 0;

            string[] nombres = new string[1000];
            double[] antiguedades = new double[1000];
            double[] valoresHora = new double[1000];
            double[] importesBruto = new double[1000];
            double[] importesNeto = new double[1000];

            do
            {
                Console.Write("Ingrese el valor por hora: ");
                numIngresadoStr = Console.ReadLine();
                while (!double.TryParse(numIngresadoStr, out valorHora) && valorHora >= 0)
                {
                    Console.WriteLine("ERROR. Ingrese un número mayor o igual a 0");
                    Console.Write("Ingrese el valor por hora: ");
                    numIngresadoStr = Console.ReadLine();
                }

                Console.Write("Ingrese el nombre: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese la antigüedad en años: ");
                numIngresadoStr = Console.ReadLine();
                while (!double.TryParse(numIngresadoStr, out antiguedad) && antiguedad >= 0)
                {
                    Console.WriteLine("ERROR. Ingrese un número mayor o igual a 0");
                    Console.Write("Ingrese la antigüedad en años: ");
                    numIngresadoStr = Console.ReadLine();
                }

                Console.Write("Ingrese la cantidad de horas trabajadas al mes: ");
                numIngresadoStr = Console.ReadLine();
                while (!double.TryParse(numIngresadoStr, out horasTrabajadasAlMes) && horasTrabajadasAlMes >= 0)
                {
                    Console.WriteLine("ERROR. Ingrese un número mayor o igual a 0");
                    Console.Write("Ingrese la antigüedad en años: ");
                    numIngresadoStr = Console.ReadLine();
                }

                importe = valorHora * horasTrabajadasAlMes;
                importeConAntiguedad = importe + (antiguedad * 150);
                descuento = 13 / 100 * importeConAntiguedad;
                importeTotal = importeConAntiguedad - descuento;

                nombres[contador] = nombre;
                antiguedades[contador] = antiguedad;
                valoresHora[contador] = valorHora;
                importesBruto[contador] = importeConAntiguedad;
                importesNeto[contador] = importeTotal;

                contador++;

                Console.Write("¿Desea agregar otro empleado? (si/no) ");
                respuesta = Console.ReadLine();
                while (respuesta != "si" && respuesta != "no")
                {
                    Console.WriteLine("ERROR. Solo puedes ingresar \"si\" o \"no\"");
                    Console.Write("¿Desea agregar otro empleado? (si/no) ");
                    respuesta = Console.ReadLine();
                }
            } while (respuesta == "si");

            for (int i = 0; i < 1000; i++)
            {
                if (nombres[i] == null)
                {
                    break;
                }

                Console.WriteLine($"Nombre: {nombres[i]}\nAntiguedad: {antiguedades[i]}\nValor por hora: {valoresHora[i]}\nImporte bruto: {importesBruto[i]}\nImporte neto: {importesNeto[i]}");
            }
        }
    }
}
