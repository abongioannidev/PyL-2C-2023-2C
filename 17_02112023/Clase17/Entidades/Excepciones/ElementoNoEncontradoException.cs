using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ElementoNoEncontradoException : Exception
    {
        public ElementoNoEncontradoException(string? message) : base(message)
        {
        }

        public ElementoNoEncontradoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
