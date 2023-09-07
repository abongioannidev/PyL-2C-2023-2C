namespace Entidades
{
    public class Animal
    {
        public static int cantidadDePatas;
        private string nombre;
        private DateTime fechaNacimiento;
        private string raza;
        private bool hambre;

        static Animal()
        {
            Animal.cantidadDePatas = 4;
        }
        public Animal(string nombre, DateTime fechaNacimiento, string raza)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.raza = raza;
        }

        public string Saludar()
        {
            //return "Hola mi nombre es " + this.nombre;
            //return string.Format("Hola mi nombre es {0}", this.nombre);
            return $"Hola mi nombre es {this.nombre} y mi raza es {this.raza} y tengo {Animal.cantidadDePatas}";
        }

        public string GetRaza()
        {
            return this.raza;
        }
        public void SetRaza(string raza)
        {
            if (!string.IsNullOrWhiteSpace(raza))
            {
                this.raza = raza;
            }
        }

        public bool GetHambre()
        { return this.hambre; }

        public void SetHambre(bool value)
        {
            this.hambre = value;
        }




    }
}