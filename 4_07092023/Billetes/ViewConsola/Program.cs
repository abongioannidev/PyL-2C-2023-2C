using Entidades;
namespace ViewConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dolar d = new Dolar(1);

            Peso p = (Peso)d;

            Euro e = (Euro)d;


            Console.WriteLine($"Cantidad de Dolares expresadas en Euros {e.GetCantidad()}");


            Console.WriteLine($"Cantidad de Dolares expresadas en Pesos {p.GetCantidad()}");


            Peso p2 = 800;

            Dolar d2 = (Dolar)p2;

            Console.WriteLine($"Cantidad de Pesos expresadas en dolares {d2.GetCantidad()}");

            Euro e2 = 1;

            Dolar d3 = (Dolar)e2;

            Console.WriteLine($"Cantidad de Euros expresadas en dolares {d3.GetCantidad()}");

            Peso p3 = (Peso)e2;
            Console.WriteLine($"Cantidad de Euros expresadas en Pesos {p3.GetCantidad()}");


            Console.WriteLine($"Comparacion entre peso y dolar {d == p2}");

            Console.WriteLine($"Comparacion entre dolar y euro {d == e}");




        }
    }
}