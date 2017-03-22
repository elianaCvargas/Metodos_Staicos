using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int elMayor;
            string dato;
 

            Console.WriteLine("Hola mundo");
            elMayor = Comparadora.retornarMayor(10, 5);
            sello.mensaje = "Nuevo mensaje";
            sello.color = ConsoleColor.DarkBlue;
            dato  = sello.imprimir();

            sello.imprimirEnColor();
            Console.ReadLine();
        }
    }
}
