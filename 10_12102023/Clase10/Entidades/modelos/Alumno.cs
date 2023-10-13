using Entidades.excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.modelos
{
    public enum EMateria { Programacion, Laboratorio };
    public class Alumno
    {
        private int dni;
        #region "Constructores"

        public Alumno(string dni)
        {
            try
            {

                this.dni = this.ValidaDni(dni);
            }
            catch (Exception ex)
            {
                throw new AlumnoInvalidoException("No se pudo crear un alumno", ex);
            }
        }

        public string Dni { get => this.dni.ToString(); set => this.dni = this.ValidaDni(value); }


        /// <summary>
        /// Metodo que devuelve un dni validado
        /// </summary>
        /// <param name="dni">Es el dni a validar</param>
        /// <returns>devuelve el dni en formato numero</returns>
        /// <exception cref="DniInvalidoException"></exception>

        private int ValidaDni(string dni)
        {

            if (dni.Length == 8)
            {
                try
                {
                    return int.Parse(dni);
                }
                catch (Exception ex)
                {
                    throw new DniInvalidoException("No se pudo convertir a DNI", ex);
                }
            }
            else
            {
                throw new DniInvalidoException("Cantidad de caracteres invalidos");
            }
        }
        #endregion
    }

}
