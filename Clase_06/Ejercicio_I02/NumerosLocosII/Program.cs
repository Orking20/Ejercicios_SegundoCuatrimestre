using System;
using System.Collections.Generic;

namespace NumerosLocosII
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Stack<int> pilaPos = new Stack<int>();
            Stack<int> pilaNeg = new Stack<int>();
            Queue<int> colaPos = new Queue<int>();
            Queue<int> colaNeg = new Queue<int>();

            //Agrega números aleatorios a la lista
            for (int i = 0; i < 20; i++)
            {
                lista.Add(GenerarNumeroAleatorio());
            }

            Console.WriteLine("Lista:");
            lista.Sort(); // Ordena la lista de menor a mayor
            foreach (int numero in lista)
            {
                if (numero > 0)
                {
                    pilaPos.Push(numero);
                }
                else
                {
                    colaNeg.Enqueue(numero);
                    Console.WriteLine(numero);
                }
            }

            lista.Reverse(); // Ordena de mayor a menor
            foreach (int numero in lista)
            {
                if (numero > 0)
                {
                    colaPos.Enqueue(numero);
                    Console.WriteLine(numero);
                }
                else
                {
                    pilaNeg.Push(numero);
                }
            }

            Console.WriteLine("Pila:");
            foreach (int num in pilaNeg)
            {
                Console.WriteLine(num);
            }
            foreach (int num in pilaPos)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Cola:");
            foreach (int num in colaNeg)
            {
                Console.WriteLine(num);
            }
            foreach (int num in colaPos)
            {
                Console.WriteLine(num);
            }
        }

        private static int GenerarNumeroAleatorio()
        {
            int numero;
            Random random = new Random();

            numero = random.Next(-100, 100);
            while (numero == 0)
            {
                numero = random.Next(-100, 100);
            }

            return numero;
        }
    }
}
