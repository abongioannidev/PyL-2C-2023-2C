using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Persona
    {
        public int IdPersona { get; set; } 
        public string Nombre { get; set; }  
        public string Apellido { get; set; }    
        public int Dni {  get; set; }
        public int IdDireccion { get; set; } 
        public Direccion Direccion { get; set; }


        public override string ToString()
        {
            return $"{this.Nombre}, {this.Apellido}, {Dni}";
        }

    }
}
