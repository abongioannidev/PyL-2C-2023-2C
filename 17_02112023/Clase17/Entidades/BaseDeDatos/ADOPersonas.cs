using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades.Excepciones;
using Entidades.Modelos;
using System.Data;

namespace Entidades.BaseDeDatos
{
    public class ADOPersonas
    {
        private static string stringConnection;

        static ADOPersonas()
        {
            ADOPersonas.stringConnection = "Server=.;Database=clase01112023;Trusted_Connection=True;";
        }

        public static List<Persona> ObternerTodasLasPersonas()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ADOPersonas.stringConnection))
                {
                    List<Persona> personas = new List<Persona>();
                    string query = "SELECT * FROM Personas";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Persona persona = new Persona();
                            persona.IdPersona = reader.GetInt32(0);
                            persona.Nombre = reader.GetString(1);
                            persona.Apellido = reader.GetString(2);
                            persona.Dni = reader.GetInt32(3);
                            persona.IdDireccion = reader.GetInt32(4);
                            personas.Add(persona);
                        }
                        return personas;
                    }
                    else
                    {
                        throw new ElementoNoEncontradoException("Tabla Vacia");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("Error al obtener un elemento por ID", ex);
            }

        }
        public static Persona ObtenerPersonaPorId(int id)
        {

            List<Persona> personas = ADOPersonas.ObternerTodasLasPersonas();

            foreach (Persona persona in personas)
            {
                if(persona.IdPersona == id)
                { 
                    return persona;
                }
            }

            throw new ElementoNoEncontradoException("Ningun elemento para ese Id");

            #region "comentario"
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(GestorSqlPersonas.stringConnection))
            //    {
            //        string query = "SELECT * FROM Personas WHERE idPersona = @id";
            //        SqlCommand command = new SqlCommand(query, connection);
            //        command.Parameters.AddWithValue("id", id);
            //        connection.Open();

            //        SqlDataReader reader = command.ExecuteReader();

            //        if (reader.HasRows)
            //        {
            //            reader.Read();
            //            Persona persona = new Persona();
            //            persona.IdPersona = reader.GetInt32(0);
            //            persona.Nombre = reader.GetString(1);
            //            persona.Apellido = reader.GetString(2);
            //            persona.Dni = reader.GetInt32(3);
            //            persona.IdDireccion = reader.GetInt32(4);

            //            return persona;
            //        }
            //        else
            //        {
            //            throw new ElementoNoEncontradoException("Ningun elemento para ese Id");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw new BaseDeDatosException("Error al obtener un elemento por ID", ex);
            //}
            #endregion
        }

        public static int AgregarNuevaPersona(Persona persona)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ADOPersonas.stringConnection))
                {
                    string query = "INSERT INTO personas (nombre,apellido,dni,idDireccion)" +
                        "values (@nombre,@apellido,@dni, @idDireccion); SELECT @@IDENTITY";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("nombre", persona.Nombre);
                    command.Parameters.AddWithValue("apellido", persona.Apellido);
                    command.Parameters.AddWithValue("dni", persona.Dni);
                    command.Parameters.AddWithValue("idDireccion", persona.IdDireccion);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    return (int)reader.GetDecimal(0);
               
                }
            }
            catch(Exception ex)
            {
                throw new BaseDeDatosException("Error al agregar una nueva persona", ex);
            }

        }

        public static bool BorrarUnaPersonaPorId(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ADOPersonas.stringConnection))
                {
                    string query = "DELETE FROM Personas WHERE idPersona=@id";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("id", id);
          
                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("Error al borrar una persona", ex);
            }

        }
        public static bool ActualizarPersonaPorId(Persona persona, int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ADOPersonas.stringConnection))
                {
                    string query = "UPDATE Personas set nombre = @nombre, apellido=@apellido," +
                        "dni=@dni,idDireccion=@idDireccion WHERE idPersona=@id";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("id", id);
                    command.Parameters.AddWithValue("nombre", persona.Nombre);
                    command.Parameters.AddWithValue("apellido", persona.Apellido);
                    command.Parameters.AddWithValue("dni", persona.Dni);
                    command.Parameters.AddWithValue("idDireccion", persona.IdDireccion);
                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;

                }
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("Error al actualizar la persona", ex);
            }
        }
    }
}
