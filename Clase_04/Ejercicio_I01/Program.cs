using System;
using BibliotecaDeClases;

namespace Ejercicio_I01
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador1 = new Sumador();
            Sumador sumador2 = new Sumador();

            Console.WriteLine(sumador1.Sumar(8, 3));
            Console.WriteLine(sumador1.Sumar("Hola", " amigos"));
            Console.WriteLine(sumador2.Sumar(9, 3));
            Console.WriteLine(sumador2.Sumar(9, 6));

            Console.WriteLine(sumador1 + sumador2);
            Console.WriteLine(sumador1 | sumador2);


        }
    }
}
