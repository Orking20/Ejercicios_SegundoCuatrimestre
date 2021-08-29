using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02
{
    class Validador
    {
        public static bool ValidarRespuesta()
        {
            bool retorno = false;
            string respuesta;

            Console.WriteLine("¿Desea continuar? (S/N) ");
            respuesta = Console.ReadLine().ToLower();
            while (respuesta != "s" && respuesta != "n")
            {
                Console.WriteLine("ERROR. Solo puedes ingresar \'S\' o \'N\'");
                Console.WriteLine("¿Desea continuar? (S/N) ");
                respuesta = Console.ReadLine().ToLower();
            }

            if (respuesta == "s")
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
