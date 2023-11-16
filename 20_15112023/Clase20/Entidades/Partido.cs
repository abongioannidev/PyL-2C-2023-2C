using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoEquipoEjecutante(string mensaje, Equipo equipo);
    public delegate void DelegadoEmpate(string resultado);
    public delegate void DelegadoGanador(Equipo equipoGanador, Equipo equipoPerdedor);
    public class Partido
    {
        private Equipo local;
        private Equipo visitante;
        private int cantidadDeDisparos;
        public event DelegadoEquipoEjecutante OnEjecutor;
        public event DelegadoEmpate OnEmpate;
        public event DelegadoGanador OnGanador;

        public Partido(Equipo local, Equipo visitante, int cantidadDeDisparos)
        {
            this.local = local;
            this.local.OnGoles += this.AsignarGol;
            this.visitante = visitante;
            this.visitante.OnGoles += this.AsignarGol;
            this.cantidadDeDisparos = cantidadDeDisparos;
        }

        public void IniciarEnfrentamiento()
        {
           Task.Run(() =>
            {
                for (int i = 0; i < this.cantidadDeDisparos; i++)
                {
                    this.AtacarLocal(i);
                    this.AtacarVisitante(i);

                }

                this.NotificarResultado();

            });
  
        }

        private void NotificarResultado()
        {
            if(this.OnGanador is not null && this.OnEmpate is not null) 
            {
                if(this.local.GolesRealizados > this.visitante.GolesRealizados)
                {
                    this.OnGanador.Invoke(this.local, this.visitante);
                }
                else if( this.visitante.GolesRealizados > this.local.GolesRealizados)
                {
                    this.OnGanador.Invoke(this.visitante, this.local);
                }
                else
                {
                    this.OnEmpate.Invoke($"" +
                        $"Empate {this.local.ToString()} - {this.visitante.ToString()}");
                }
            
            
            }
        }

        private void AtacarLocal(int numJugador)
        {
            this.NotificarEjecutante(this.local);
            this.local.AtacarJugador(numJugador);
            Thread.Sleep(2000);
        }

        private void AtacarVisitante(int numJugador)
        {
            this.NotificarEjecutante(this.visitante);
            this.visitante.AtacarJugador(numJugador);
            Thread.Sleep(2000);
        }

        private void NotificarEjecutante(Equipo equipo)
        {
            if(this.OnEjecutor is not null)
            {
                this.OnEjecutor.Invoke($"Pateando => {equipo.Nombre}", equipo);
            }
        }

        private void AsignarGol(bool gol, Equipo equipo)
        {
            if(gol)
            {
                equipo.GolesRealizados++;
            }
        }
    }
}
