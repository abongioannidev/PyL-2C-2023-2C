using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {

        private CancellationTokenSource cancellation;

        public void AbrirNegocio(Action<Persona> operarPersona)
        {
            this.cancellation = new CancellationTokenSource();
            int id = 0;
            Task.Run(() =>
            {
                do
                {
                    id++;
                    Persona persona = GestorBaseDeDatos.ObtenerPersonaPorId(id);
                    operarPersona(persona);
                    Thread.Sleep(1000);

                } while (!this.cancellation.IsCancellationRequested);
            }, this.cancellation.Token);
        }

        public void CerrarNegocio()
        {
            this.cancellation.Cancel();
        }


    }
}
