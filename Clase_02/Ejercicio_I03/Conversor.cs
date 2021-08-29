using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I03
{
    class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string numeroBinario = "";
            string numeroBinarioConGuion = "";
            string numeroRetorno = "";

            while (numeroEntero / 2 != 0)
            {
                if (numeroEntero % 2 == 1)
                {
                    numeroBinario += "1";
                }
                else
                {
                    numeroBinario += "0";
                }

                numeroEntero /= 2;
            }

            if (numeroEntero == 1)
            {
                numeroBinario += "1";
            }

            while (numeroBinario.Length % 4 != 0)
            {
                numeroBinario += "0";
            }

            for (int i = 1; i <= numeroBinario.Length; i++)
            {
                numeroBinarioConGuion += numeroBinario[i - 1];

                if (i % 4 == 0 && i != numeroBinario.Length)
                {
                    numeroBinarioConGuion += "-";
                }
            }

            foreach (char digito in numeroBinarioConGuion)
            {
                numeroRetorno = digito + numeroRetorno;
            }

            return numeroRetorno;
        }

        public static double ConvertirBinarioADecimal(string numeroBinario)
        {
            int potencia;
            double multiplicacion;
            string digito;
            double acumulador = 0;

            for (int i = 0; i < numeroBinario.Length; i++)
            {
                digito = numeroBinario[i].ToString();
                potencia = numeroBinario.Length - i - 1;
                multiplicacion = int.Parse(digito) * Math.Pow(2, potencia);
                acumulador += multiplicacion;
            }

            return acumulador;
        }
    }
}
