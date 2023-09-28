using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Profesor : Persona
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

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Catedra: {this.catedra}");

            return sb.ToString();
        }

        public override string Saludar()
        {
            return "Hola soy un profesor";
        }

        public override string ToString()
        {
            return "Soy un profesor";
        }
    }
}
