using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Avion : IVolador
    {
        public int Combustible { get { return 1000; } }

        public string Aterrizar()
        {
            return "Avion Aterrizando";
        }

        public string Despegar()
        {
            return "Avion despegando";
        }

    }
}
