using System;

namespace Ejercicio_C01
{
    class Program
    {
        static void Main(string[] args)
        {
            string numDecimalStr;
            int numDecimal;
            string numBinario;
            string respuesta;

            do
            {
                Console.Write("Ingrese un número entero decimal para convertir en binario: ");
                numDecimalStr = Console.ReadLine();
                while (!int.TryParse(numDecimalStr, out numDecimal))
                {
                    Console.WriteLine("ERROR. Ingrese un numero entero para convertir a decimal");
                    Console.Write("Ingrese un número decimal para convertir en binario: ");
                    numDecimalStr = Console.ReadLine();
                }

                Console.Write("Ingrese un número binario para convertir en decimal: ");
                numBinario = Console.ReadLine();

                Console.WriteLine(Conversor.ConvertirDecimalABinario(numDecimal));
                Console.WriteLine(Conversor.ConvertirBinarioADecimal(numBinario));

                Console.WriteLine();
            } while (Validador.ValidarRespuesta());
        }
    }
}
