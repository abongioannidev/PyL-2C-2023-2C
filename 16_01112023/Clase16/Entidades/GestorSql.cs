using System.Data.SqlClient;
namespace Entidades
{
    public static class GestorSql
    {
        private static string stringConnection;

        static GestorSql()
        {
            GestorSql.stringConnection = "Server=.;Database=clase01112023;Trusted_Connection=True;";
        }



        public static string GetDatosPersona(int id)
        {
            SqlConnection connection = new SqlConnection(GestorSql.stringConnection);

            string sentencia = $"SELECT idPersona,nombre,apellido FROM PERSONAS WHERE idPersona={id}";

            try
            {
                SqlCommand command = new SqlCommand(sentencia, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(); 
          
                if(reader.Read())
                {
                    return $"Persona con ID {reader.GetInt32(0)} =>{reader.GetString(1)},{reader.GetString(2)}";
                }
                return "No encotre un nombre para el ID RECIBIDO";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                if(connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            
        }


        public static void GetAllPersonas()
        {
            SqlConnection connection = new SqlConnection(GestorSql.stringConnection);

            string sentencia = $"SELECT * FROM PERSONAS";

            try
            {
                SqlCommand command = new SqlCommand(sentencia, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
           
                while(reader.Read()) 
                {
                    Console.WriteLine($"Persona con ID {reader.GetInt32(0)} =>{reader.GetString(1)},{reader.GetString(2)}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }


    }
}