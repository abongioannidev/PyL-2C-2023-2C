using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {

        public bool PatearAlArco()
        {
            Random rand = new Random();
            return rand.Next(0, 2) == 1;
        }
    }
}
