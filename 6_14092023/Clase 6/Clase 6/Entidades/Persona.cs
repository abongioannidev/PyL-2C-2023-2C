using System.Text;

namespace Entidades
{
    public class Persona
    {
        private int dni;
        private string nombre;
        private string apellido;

        public Persona(int dni, string nombre, string apellido)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"DNI: {this.dni}");
            return sb.ToString();
        }
    }
}