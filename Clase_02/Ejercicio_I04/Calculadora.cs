using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I04
{
    public static class Calculadora
    {
        public static double Calcular(double num1, double num2, string operador)
        {
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;

                case "-":
                    resultado = num1 - num2;
                    break;

                case "*":
                    resultado = num1 * num2;
                    break;

                case "/":
                    if (Validar(num2))
                    {
                        resultado = num1 / num2;
                    }
                    break;
            }

            return resultado;
        }

        private static bool Validar(double divisor)
        {
            bool retorno = false;

            if (divisor != 0)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
