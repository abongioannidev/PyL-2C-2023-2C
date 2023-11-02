using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string[] cosas;

        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.cosas = cosas;
        }

        [System.Text.Json.Serialization.JsonIgnore]
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string[] Cosas { get => cosas; set => cosas = value; }
    }
}
