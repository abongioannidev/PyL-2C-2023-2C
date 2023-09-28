﻿using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        private string apellido;
        private int dni;

        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Dni: {this.dni}");

            return sb.ToString();
        }

        public abstract string Saludar();
        
    }
}