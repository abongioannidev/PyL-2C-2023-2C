using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Alumno : Persona
    {
        private string legajo;
        private List<string> materias;

        public Alumno(string nombre, string apellido, int dni, string legajo, List<string> materias)
            : base(nombre, apellido, dni)
        {
            this.legajo = legajo;
            this.materias = materias;
        }

        public Alumno(string nombre, string apellido, int dni, string legajo)
            : this(nombre, apellido, dni, legajo, new List<string>())
        {

        }


        public string Estudiar()
        {
            return "Estoy estudiando...";
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Legajo: {this.legajo}");

            return sb.ToString();
        }

        public override string Saludar()
        {
            return "Hola soy un alumno";
        }

        public static bool operator ==(Alumno a, Alumno b)
        {
            return a.legajo == b.legajo;
        }

        public static bool operator !=(Alumno a, Alumno b)
        { 
            return !(a == b); 
        }

        public override bool Equals(object? obj)
        {
            if(obj is Alumno a)
            {
                return this == a;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.legajo.GetHashCode();
        }
    }
}
