using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.excepciones
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(string? message) : base(message)
        {
        }

        public UnaExcepcion(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
