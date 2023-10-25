using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Fantasma : IVolador
    {
        public int Combustible { get {  return 500; } }

        public string Aterrizar()
        {
            return "Fantasma Aterrizando";
        }

        public string Despegar()
        {
            return "Fantasma despegando";
        }
    }
}
