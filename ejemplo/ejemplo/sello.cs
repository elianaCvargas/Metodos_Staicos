using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo
{
    class sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string imprimir()
        {
            return "algo";
        }

        public static void borrar()
        {
            sello.mensaje = "";
            //return mensaje;
        }

        public static void imprimirEnColor()
        {
            Console.ForegroundColor = sello.color;
            Console.WriteLine(sello.mensaje);
        }
    }
}
