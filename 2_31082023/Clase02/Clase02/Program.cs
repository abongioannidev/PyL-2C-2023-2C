using Entidades;
using System.Text;

namespace Clase02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string platoElegido;
            //string bebidaElegida;
            int numero = 10;
            string cadena = "";

            
            DateTime fecha = DateTime.Now;
            TimeSpan ts = TimeSpan.Zero;

            Console.WriteLine(fecha.ToString("dd/mm/yyyy"));
            //StringBuilder sb = new StringBuilder("Hola Mundo");
            //sb.AppendFormat("Como estas {0}",numero);
            //Console.WriteLine(sb);
            //foreach (char c in saludo)
            //{
            //    Console.WriteLine(c);
            //}

            //string mensaje = "Ingresa un plato elegido (\"Pizza\", \"Hamburguesa\", \"Ensalada\")";

            //platoElegido = Validadora.ValidarIngreso(mensaje, "Pizza", "Hamburguesa", "Ensalada");

            ////Console.WriteLine("Ingresa un plato elegido (\"Pizza\", \"Hamburguesa\", \"Ensalada\")");
            ////platoElegido = Console.ReadLine();  

            ////while(platoElegido != "Pizza" && platoElegido != "Hamburguesa" && platoElegido!= "Ensalada") 
            ////{
            ////    Console.WriteLine("ERROR!! RE Ingresa un plato elegido (\"Pizza\", \"Hamburguesa\", \"Ensalada\")");
            ////    platoElegido = Console.ReadLine();
            ////}

            //mensaje = "Ingresa un la Bebida elegida (\"Agua\", \"Jugo\")";
            //bebidaElegida = Validadora.ValidarIngreso(mensaje, "Agua", "Jugo");


            ////Console.WriteLine("Ingresa un la Bebida elegida (\"Refresco\", \"Agua\", \"Jugo\")");
            ////bebidaElegida = Console.ReadLine();

            ////while (bebidaElegida != "Refresco" && bebidaElegida != "Agua" && bebidaElegida != "Jugo")
            ////{
            ////    Console.WriteLine("ERROR!! RE Ingresa un la Bebida elegida (\"Refresco\", \"Agua\", \"Jugo\")");
            ////    bebidaElegida = Console.ReadLine();
            ////}

            
            
            //Console.WriteLine($"{bebidaElegida} y {platoElegido}");

            Console.ReadKey();

            

        }
    }

     


    
}