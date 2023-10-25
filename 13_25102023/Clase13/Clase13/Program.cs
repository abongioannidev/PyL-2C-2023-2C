using Entidades;
using Entidades.Interfaces;
using Entidades.Modelos;

namespace Clase13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ave ave = new Ave();
            IVolador fantasma = new Fantasma();
            IVolador avion = new Avion();

            //List<IVolador> voladores = new List<IVolador>();

            //Ave ave2 = new Ave();



            //voladores.Add(ave);
            //voladores.Add(fantasma);
            //voladores.Add(avion);

            //foreach (IVolador item in voladores)
            //{
            //    Console.WriteLine(item.Despegar());
            //}

            Console.WriteLine(ave.Despegar());

            //PistaDeAterrizaje pistaDeAterrizajeDeAves = new PistaDeAterrizaje(fantasma);

            //pistaDeAterrizajeDeAves.Despegar();
            //pistaDeAterrizajeDeAves.Aterrizar();
            //pistaDeAterrizajeDeAves.VerificarCargaDeCombustible();
            
            
        }
    }
}