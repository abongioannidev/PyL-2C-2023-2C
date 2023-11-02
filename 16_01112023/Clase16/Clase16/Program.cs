using Entidades;
namespace Clase16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GestorSql.GetDatosPersona(10));

            Console.WriteLine("*******************************************");
            GestorSql.GetAllPersonas();
        }
    }
}