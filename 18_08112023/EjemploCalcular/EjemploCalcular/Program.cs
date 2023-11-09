namespace EjemploCalcular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var login = Empezar(3);
            login("ale", "1234");
            login("ale", "1234");
            login("admin", "12345");
            login("admin", "12345");
        }


        static Action<string, string> Empezar(int cantidad)
        {

            int ejecuciones = 0;
            Console.WriteLine("Me Inicializo");
            return (usuario, password) =>
            {
                if (!AsertarLogin(usuario, password))
                {
                    ejecuciones++;
                    if (ejecuciones < cantidad)
                    {

                        Console.WriteLine($"Me intente loguear {ejecuciones}");
                    }
                    else
                    {
                        Console.WriteLine("Usuario Bloqueado");
                    }

                }
                else
                {
                    Console.WriteLine("Login exitoso");
                }

            };
        }

        static bool AsertarLogin(string usuario, string password)
        {
            return usuario == "Admin" && password == "12345";
        }


    }


}