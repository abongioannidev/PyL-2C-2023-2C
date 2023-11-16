using Entidades;
namespace EventosConsola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Equipo bocaJrs = new Equipo("Boca Juniors");
            Equipo fluminense = new Equipo("Fluminense");
            Partido tandaPenales = new Partido(fluminense, bocaJrs, 5);
            tandaPenales.OnGanador += MostrarGanador;
            tandaPenales.OnEjecutor += MostrarEjecutor;
            tandaPenales.OnEmpate += MostrarEmpate;


            tandaPenales.IniciarEnfrentamiento();


            Console.ReadKey();
        }


        static void MostrarEjecutor(string mensaje, Equipo equipo)
        {
            Console.WriteLine(mensaje);
        }

        static void MostrarGanador(Equipo ganador, Equipo perdedor)
        {
            Console.WriteLine($"el ganador es => {ganador}");
            Console.WriteLine($"el perdedor es => {perdedor}");
        }

        static void MostrarEmpate(string mensaje )
        {
            Console.WriteLine(mensaje);
        }


    }
}