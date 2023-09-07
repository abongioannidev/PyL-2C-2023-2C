using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {

        public string nombre;
        private string apellido;
        private int dni;
        private int edad;


        private Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona():this(111111)
        {

        }
        public Persona(int dni)
        {
            this.dni = dni;
        }

        public Persona(int dni, string apellido)
            :this(dni)
        {
            this.apellido = apellido;
        }
        public Persona(int dni, string apellido, string nombre)
            :this(dni,apellido)
        {
            this.nombre = nombre;
        }

        public Persona(int dni, string apellido, string nombre, int edad)
            :this(dni,apellido,nombre)
        {
            this.edad = edad;
        }


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Dni: {this.dni}");
            sb.AppendLine($"Edad: {this.edad}");

            return sb.ToString();
        }

        public static bool operator == (Persona p1, Persona p2)
        {
            //if(p1.dni == p2.dni)
            //{
            //    return true;
            //}
            //return false;
            return p1.dni == p2.dni;
        }
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }

        public static string operator + (Persona p1, Persona p2)
        {
            return $"{p1.nombre} y {p2.nombre}";
        }
        public static Persona operator +(Persona p1, int numero)
        { 
            p1.edad += numero;
            return p1;
        }


        public static implicit operator int (Persona p1)
        {
            return p1.edad;
        }
        public static explicit operator string (Persona p1)
        {
            return p1.MostrarDatos();
        }


        public static Persona GetPersona(string nombre)
        {
            return new Persona(nombre);
        }


        public static implicit operator Persona(string nombre)
        {
            return new Persona(nombre);
        }

        public static implicit operator Persona(int dni)
        {
            return new Persona(dni);
        }
    }
}
