namespace Entidades
{

    
    public static class Validadora
    {

        public static string ValidarIngreso(string mensaje, params string[] argumentos)
        {

            Console.WriteLine(mensaje);
            string datoIngresado = Console.ReadLine();


            while (!argumentos.Contains(datoIngresado))
            {
                Console.WriteLine($"ERROR!! RE {mensaje}");
                datoIngresado = Console.ReadLine();
            }

            return datoIngresado;
        }


    }
}