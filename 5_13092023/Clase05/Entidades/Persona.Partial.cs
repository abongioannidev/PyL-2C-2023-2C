namespace Entidades
{
    public partial class Persona
    {
        public string MostrarDatos()
        {
            return $"Soy {this.nombre}, {this.apellido} y tengo {this.edad} años";
        }
    }
}