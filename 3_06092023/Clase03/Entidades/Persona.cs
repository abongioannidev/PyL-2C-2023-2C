using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public static void Alimentar(Animal animal)
        {
            animal.SetHambre(true);
        }
    }
}
