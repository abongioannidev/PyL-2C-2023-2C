namespace Entidades
{
    public partial class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;

        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }


    }
}