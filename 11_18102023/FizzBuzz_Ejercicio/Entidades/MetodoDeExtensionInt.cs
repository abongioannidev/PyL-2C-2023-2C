using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodoDeExtensionInt
    {
        public static string FizzBuzz(this int valor)
        {
       
            if ((valor % 3) == 0 && (valor % 5) == 0)
            {
                return "FizzBuzz";
            }

            if ((valor % 3) == 0)
            {
                return "Fizz";
            }

            if ((valor % 5) == 0)
            {
                return "Buzz";
            }
            return valor.ToString();
        }
    }
}
