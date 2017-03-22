using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo
{
    class Comparadora
    {
        /// <summary>
        /// Compara dos numeros para saber cual es el  mayor
        /// </summary>
        /// <param name="num1">Primer numero entero</param>
        /// <param name="num2">Segundo  numero  entero</param>
        /// <returns>El numero mayor</returns>
        public static int retornarMayor(int num1, int num2)
        {
            int retorno = 0;
            if (num1 > num2)
                retorno = num1;
            else
                retorno = num2;
            return retorno;
        }
    }
}
