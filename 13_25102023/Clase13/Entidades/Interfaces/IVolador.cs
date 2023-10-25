using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IVolador
    {

        public int Combustible {  get;  }
        public string Despegar();
        public string Aterrizar();
    }
}
