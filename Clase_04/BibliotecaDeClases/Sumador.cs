using System;

namespace BibliotecaDeClases
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0)
        {
            
        }

        public long Sumar(long numero1, long numero2)
        {
            this.cantidadSumas++;

            return numero1 + numero2;
        }

        public string Sumar(string cadena1, string cadena2)
        {
            this.cantidadSumas++;

            return cadena1 + cadena2;
        }

        public static explicit operator int(Sumador sumador)
        {
            return sumador.cantidadSumas;
        }

        public static long operator + (Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas + sumador2.cantidadSumas;
        }

        public static bool operator | (Sumador sumador1, Sumador sumador2)
        {
            bool retorno = false;

            if (sumador1.cantidadSumas == sumador2.cantidadSumas)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
