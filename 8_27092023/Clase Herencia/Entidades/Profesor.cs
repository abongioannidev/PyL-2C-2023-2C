using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private string catedra;
        public Profesor(string nombre, string apellido, int dni, string catedra)
            : base(nombre, apellido, dni)
        {
            this.catedra = catedra;
        }

        public string Corregir()
        {
            return "Estoy corrigiendo...";
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Catedra: {this.catedra}");

            return sb.ToString();
        }
    }
}
