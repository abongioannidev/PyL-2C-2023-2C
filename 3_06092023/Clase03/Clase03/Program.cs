using Entidades;
namespace Clase03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal animalDeAle = new Animal("Firulais",DateTime.Now,"PP");
            Animal animalLucas = new Animal("Chihuahua",DateTime.Now,"Chihuahua");


            Animal animalNuevo = animalDeAle;


            int numero = 10;

            int numeroCopiado = numero;

            

            Console.WriteLine(numero);
            numeroCopiado = 90;
            Console.WriteLine(numero);
            Console.WriteLine(numeroCopiado);

            Console.WriteLine(animalDeAle.Saludar());  
            Console.WriteLine(animalNuevo.Saludar());
            animalDeAle.SetRaza("Nueva raza");

            Console.WriteLine(animalDeAle.Saludar());
            Console.WriteLine(animalNuevo.Saludar());


            animalNuevo.SetRaza("Raza de animal nuevo");

            Console.WriteLine(animalDeAle.Saludar());
            Console.WriteLine(animalNuevo.Saludar());
            //Console.WriteLine(animalDeAle.GetHambre());

            //Animal.cantidadDePatas = 67;

            //Persona.Alimentar(animalDeAle);

            //Console.WriteLine(animalDeAle.GetHambre());
            //Console.WriteLine(animalDeAle.Saludar());
            //Console.WriteLine(animalLucas.Saludar());




            //Console.WriteLine("Ingrese un numero");
            //string ingreso = Console.ReadLine();
            //int ingresoConvertido;
            //bool resultado = Program.TryParse(ingreso, out ingresoConvertido);

            //DateTime fecha;
            //DateTime.TryParse(ingreso, out fecha);

            //Console.WriteLine(fecha);

            //Console.WriteLine(fecha.Year);
            //Console.WriteLine(fecha.Month);
            //Console.WriteLine(fecha.Day);
            //Console.WriteLine($"el dia es {fechas[0]} el mes es {fechas[1]} y el año es {fechas[2]}");


            //Console.WriteLine(resultado);
            //Console.WriteLine(ingresoConvertido);
            Console.WriteLine("Hello, World!");
        }





        public static bool TryParse(string input, out int valor) 
        { 
         
            foreach (var item in input)
            {
                if(item <'0'  || item > '9')
                {
                    //No puedo convertir
                    valor = 0;
                    return false;
                }

            }
            //Puedo convertir
            valor = int.Parse(input);
            return true;
        }

    }
}