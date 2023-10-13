using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.excepciones
{
    public class AlumnoInvalidoException : Exception
    {
        public AlumnoInvalidoException(string? message) : base(message)
        {
        }

        public AlumnoInvalidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
