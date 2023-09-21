using Entidades;

namespace Clase07
{
    internal class Program
    {
        //enum EAdhereso { Queso = 10, Tomate = 5, Mayonesa = 0 };
        static void Main(string[] args)
        {

            string nombre;
            string apellido;
            string fechaNacimientoStr;
            DateTime fechaNacimiento;
            string dni;
            string dniStr;
            string telefono;



            //int precioHamburguesa = 1000;
            //List<EAdhereso> lista = new List<EAdhereso> { EAdhereso.Queso, EAdhereso.Tomate };

            //foreach (var item in lista)
            //{
            //    int porcentaje = (int)item;
            //    //NO HACER ASI
            //    //int porcentaje;

            //    //switch (item)
            //    //{
            //    //    case EAdhereso.Tomate:
            //    //        porcentaje = 5;
            //    //        break;
            //    //    case EAdhereso.Queso:
            //    //        porcentaje = 10;
            //    //        break;
            //    //    default:
            //    //        porcentaje = 0;
            //    //        break;
            //    //}

            //    int incremento = precioHamburguesa * porcentaje / 100;
            //    precioHamburguesa = precioHamburguesa + incremento;
            //}


            //Console.WriteLine($"El precio con incremento es {precioHamburguesa}");


            //Console.WriteLine("Ingrese el nombre de la persona");
            //nombre = Console.ReadLine();

            //Console.WriteLine("Ingrese el apellido de la persona");
            //apellido = Console.ReadLine();

            //Console.WriteLine("Ingrese la fecha de nacimiento de la persona");
            //fechaNacimientoStr = Console.ReadLine();

            //DateTime.TryParse(fechaNacimientoStr, out fechaNacimiento);


            //Console.WriteLine("Ingrese el dni de la persona");
            //dniStr = Console.ReadLine();

            //int.TryParse(dniStr, out dni);



            //Persona persona = new Persona("Aleja", "Bongioa",new DateTime(1987,05,30), "12345678");

            //dni = persona.Dni;
            //persona.Dni = 1111111;

            //Console.WriteLine(persona.Edad);

            //Console.WriteLine(persona.MostrarDatos());

            //Persona.ETipos t = (Persona.ETipos)120;

            //Console.WriteLine(t.ToString());

            Persona donRamon = new Persona("Ramon", "Valdez", DateTime.Now, "12345678");



            Console.WriteLine(donRamon["apellido"]);

            donRamon.AddMateria(EMaterias.Labo);
            donRamon.AddNota(EMaterias.Labo, 10);
            donRamon.AddNota(EMaterias.Labo, 8);


            List<int> notas = donRamon[EMaterias.Programacion];

            foreach (var item in notas)
            {
                Console.WriteLine(item);
            }


        }
    }
}