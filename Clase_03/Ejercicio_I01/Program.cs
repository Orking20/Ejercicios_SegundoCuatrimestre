using System;
using BibliotecaDeClases;

namespace Ejercicio_I01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Lucas", 56000);
            Cuenta cuenta2 = new Cuenta("Mateo", 71000);
            Cuenta cuenta3 = new Cuenta("Marcos", 37500);

            Console.WriteLine(cuenta2.Mostrar());
            cuenta2.Ingresar(67000);
            Console.WriteLine(cuenta2.Mostrar());
            cuenta2.Retirar(8000);
            Console.WriteLine(cuenta2.Mostrar());
            cuenta2.Retirar(16000);
            Console.WriteLine(cuenta2.Mostrar());
            cuenta2.Ingresar(500);
            Console.WriteLine(cuenta2.Mostrar());
        }
    }
}
