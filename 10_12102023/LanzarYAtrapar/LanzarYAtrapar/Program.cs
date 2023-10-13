using Entidades;
using Entidades.excepciones;

namespace LanzarYAtrapar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtraClase otraClase = new OtraClase();

            try
            {

                otraClase.MiMetodoDeInstancia();
            }
            catch (MiExcepcion ex)
            {
                Console.WriteLine(ex.Message);
                Exception inner = ex.InnerException;
                while (inner != null)
                {
                    Console.WriteLine(inner.Message);
                    inner= inner.InnerException;
                }
            }
        }
    }
}