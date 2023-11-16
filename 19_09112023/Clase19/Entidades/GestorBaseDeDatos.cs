using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GestorBaseDeDatos
    {
        private static string stringConnection;

        static GestorBaseDeDatos()
        {
            GestorBaseDeDatos.stringConnection = "Server=.;Database=clase01112023;Trusted_Connection=True;";
        }


        public static Persona ObtenerPersonaPorId(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorBaseDeDatos.stringConnection))
                {

                    string query = "SELECT P.nombre,P.apellido,P.dni,D.calle,D.localidad FROM personas AS P INNER JOIN direcciones AS D ON P.idDireccion = D.idDireccion WHERE P.idPersona =@id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Persona persona = new Persona();

                        persona.Nombre = reader.GetString(0);
                        persona.Apellido = reader.GetString(1);
                        persona.Dni = reader.GetInt32(2);

                        Direccion direccion = new Direccion();
                        direccion.Calle = reader.GetString(3);
                        direccion.Localidad = reader.GetString(4);

                        persona.Direccion = direccion;
                        return persona;
                    }
                    else
                    {
                        throw new Exception("Persona no encontrada");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener un elemento por ID", ex);
            }
        }
    }
}
