namespace Entidades
{
    public class Persona : ICloneable
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni {  get; set; }
        public Direccion Direccion { get; set; }

        public object Clone()
        {
            Persona p = new Persona();

            p.Nombre = this.Nombre;
            p.Apellido = this.Nombre;

            return p;
        }

        public override string ToString()
        {
            return $"{this.Apellido},{Nombre}";
        }

    }
}