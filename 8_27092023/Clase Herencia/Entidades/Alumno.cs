using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
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

        public string Legajo { get => legajo; set => legajo = value; }
        public List<string> Materias { get => materias; set => materias = value; }

        public string Estudiar()
        {
            return "Estoy estudiando...";
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Legajo: {this.legajo}");

            return sb.ToString();
        }
    }
}
