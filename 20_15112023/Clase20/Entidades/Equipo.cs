using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoResultado(bool gol, Equipo equipo);
    public class Equipo
    {
        private int golesRealizados;
        private string nombre;
        private List<Jugador> jugadores;
        public event DelegadoResultado OnGoles;

        public int GolesRealizados { get => this.golesRealizados; set => this.golesRealizados = value; }
        public string Nombre { get => this.nombre; }

        public string ImgPateando { get; set; }
        public string ImgGanador { get; set; }
        public string ImgPerdedor { get; set; }


        public Equipo(string nombre)
        {
            this.nombre = nombre;
            this.AgregarJugadores(11);
        }

        private void AgregarJugadores(int cantidad)
        {
            this.jugadores = new List<Jugador>();
            for (int i = 0; i < cantidad; i++)
            {
                this.jugadores.Add(new Jugador());
            }
        }

        public void AtacarJugador(int numeroDeJugador)
        {
            if(numeroDeJugador < this.jugadores.Count && this.OnGoles is not null)
            {
                Jugador jugador = this.jugadores[numeroDeJugador];
                bool resultado = jugador.PatearAlArco();
                this.OnGoles(resultado, this);
            }
        }


        public override string ToString()
        {
            return $"{this.nombre}, cantidad de goles => {this.golesRealizados}";
        }

    }
}
