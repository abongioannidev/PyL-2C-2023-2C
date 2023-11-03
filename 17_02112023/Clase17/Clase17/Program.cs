using Entidades.BaseDeDatos;
using Entidades.Modelos;

namespace Clase17
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Persona personaNueva = new Persona() { Nombre = "Consola34", Apellido = "Csharp6.0", Dni = 11223344, IdDireccion = 99 };

            int idDePersona = ADOPersonas.AgregarNuevaPersona(personaNueva);
           
            Console.WriteLine($"Agregue con exito {idDePersona}");
            

            Console.WriteLine("*****************************");

            Persona p = ADOPersonas.ObtenerPersonaPorId(idDePersona);
            Console.WriteLine(p.ToString());


            Console.WriteLine("*****************************");
            if (ADOPersonas.BorrarUnaPersonaPorId(105))
            {
                Console.WriteLine($"Borre con exito una persona");
            }

            Console.WriteLine("*****************************");
            Persona personaAActualizar = new Persona() { Nombre = "PersonaActualizada", Apellido = "Update", Dni = 55554444, IdDireccion = 50 };
            if (ADOPersonas.ActualizarPersonaPorId(personaAActualizar, 34))
            {
                Console.WriteLine($"Actualice una persona");
            }


        }
    }
}