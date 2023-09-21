namespace Entidades
{
    public enum EMaterias { Programacion, Labo }
    public class Persona
    {
       
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private string dni;
        private string telefono;

        private Dictionary<EMaterias, List<int>> notas;


        private Persona ()
        {
           
        }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento, string dni) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.Dni = dni;
            this.notas = new Dictionary<EMaterias, List<int>>();
            
        }

        public string this[string value]
        {
            get
            {
                switch(value)
                {
                    case "nombre":
                        return this.nombre;
                    case "apellido":
                        return this.apellido;
                    case "edad":
                        return this.Edad.ToString();

                }

                return "Propiedad desconocida";
            }
        }
        public string this[int value, string value2]
        {
            get
            {
                return "Hola Mundo";
            }
        }

        public void AddMateria(EMaterias materia)
        {
            if(!this.notas.ContainsKey(materia))
            {
                this.notas.Add(materia, new List<int>());
            }
        }
        public void AddNota(EMaterias materia, int nota)
        {
            if(this.notas.ContainsKey(materia))
            {
                List<int> notas  = this[materia];
                notas.Add(nota);    
            }
        }

        public List<int> this[EMaterias materia]
        {
            get
            {
                if(this.notas.ContainsKey(materia))
                {
                    return this.notas[materia];
                }
                return null;
            }
        }

        public string Dni
        {
            get
            {
                return this.dni;
            }
            private set
            {

                if (!string.IsNullOrWhiteSpace(value) && this.ValidaDni(value))
                {
                    this.dni = value;
                }
                else
                {
                    this.dni = "Numero Invalido";
                }
            }
        }

        public int Edad
        {
            get
            {
                return DateTime.Now.Year - this.fechaNacimiento.Year;
            }
        }


        private bool ValidaDni(string value)
        {
            return int.TryParse(value, out int result) && result > 9_999_999;
        }


        public string MostrarDatos()
        {
            return $"mi nombre es {this.nombre}, {this.apellido}\nMi dni es {this.dni}";
        }

        public static implicit operator Persona(string dni)
        {
            Persona p = new Persona();
            p.Dni = dni;
            return p ;
        }

    }
}