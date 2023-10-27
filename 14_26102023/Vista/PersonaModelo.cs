using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    internal class PersonaModelo
    {
        internal string Nombre { get; set; }
        internal string Apellido { get; set; }
        internal int Dni { get; set; }

        internal Persona GetPersona()
        {
            return new Persona(this.Nombre, this.Apellido, this.Dni);
        }
    }
}
