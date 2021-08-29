/* Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.
 * El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15.
 * El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
 * Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.*/

using System;

namespace Ejercicio_I05
{
    class Program
    {
        static void Main(string[] args)
        {
            string numIngresadoStr;
            int numIngresado;
            int sumaPrimerCentro;
            int sumaSegundoCentro;
            bool flag = false;

            Console.Write("Ingrese un número entero positivo: ");
            numIngresadoStr = Console.ReadLine();
            while(!int.TryParse(numIngresadoStr, out numIngresado) || numIngresado < 1)
            {
                Console.Write("ERROR. Ingrese un número entero positivo: ");
                numIngresadoStr = Console.ReadLine();
            }

            for (int pivot = 2; pivot < numIngresado; pivot++)
            {
                sumaPrimerCentro = 0;
                sumaSegundoCentro = 0;

                for (int i = 1; i < pivot; i++)
                {
                    sumaPrimerCentro += i;
                }
                for (int i = pivot + 1; i <= numIngresado; i++)
                {
                    sumaSegundoCentro += i;
                }

                if (sumaPrimerCentro == sumaSegundoCentro)
                {
                    Console.WriteLine($"\nEl centro numérico entre 1 y {numIngresado} es {pivot}");
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine($"\nNo existe centro numérico entre 1 y {numIngresado}");
            }
        }
    }
}
