using System.Text;

namespace Entidades
{
    public class Estudiante
    {
        private string apellido;
        private string nombre;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            Estudiante.random = new Random();
        }

        public Estudiante(string apellido, string nombre, string legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            if(nota > 0 && nota < 11)
            {
                this.notaPrimerParcial = nota;
            }
        }

        public void SetNotaSegundoParcial(int nota)
        {
            if (nota > 0 && nota < 11)
            {
                this.notaSegundoParcial = nota;
            }
        }

        private float CalcularPromedio()
        {
            return ((float)(this.notaPrimerParcial + this.notaSegundoParcial)) / 2;
        }

        public double CalcularNotaFinal()
        {
            if(notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                return Estudiante.random.Next(6, 11);
            }
            else
            {
                return -1;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            double notaFinal = CalcularNotaFinal();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Nota Primer Parcial: {this.notaPrimerParcial}");
            sb.AppendLine($"Nota Segundo Parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");
            if( notaFinal < 0)
            {
                sb.AppendLine("Alumno desaprobado");
            }
            else
            {
                sb.AppendLine($"Nota final: {notaFinal}");
            }

            return sb.ToString();
        }
    }
}