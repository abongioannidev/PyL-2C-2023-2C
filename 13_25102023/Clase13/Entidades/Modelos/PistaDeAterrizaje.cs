using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class PistaDeAterrizaje
    {
        private IVolador volador;

        public PistaDeAterrizaje(IVolador volador)
        {
            this.volador = volador;
        }

        public void Aterrizar()
        {
            Console.WriteLine(this.volador.Aterrizar());
        }

        public void Despegar()
        {
            Console.WriteLine(this.volador.Despegar());
        }

        public void VerificarCargaDeCombustible()
        {
            Console.WriteLine($"El combustible del {this.volador.GetType().Name} es {this.volador.Combustible}");
        }
    }
}
