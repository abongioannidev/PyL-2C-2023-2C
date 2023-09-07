using Entidades;
namespace Clase04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string operadorUno;
            //string operadorDos;
            //Console.WriteLine("Ingrese un numero");
            // operadorUno = Console.ReadLine();

            //Console.WriteLine("Ingrese el segundon numero");
            //operadorDos = Console.ReadLine();

            //int resultado = Calculadora.Sumar(operadorUno,operadorDos);
            //Console.WriteLine($"El resultado es {resultado}");
            //Console.ReadKey();

            //double numero = 90;
            //double numero2 = 0;

            //double resultado = numero / numero2;

            //Console.WriteLine($"El resulatdo es {resultado}");

            //double result = Calculadora.Operar(10, 0,'/');

            //Console.WriteLine($"El resultado es {result}");

            //Persona persona = new Persona(12345678,"Mosquella");
            //Persona persona2 = new Persona(1234567890);
 
            ////var resultado = persona + persona2;
            //bool comparacion  = persona != persona2;
            //Console.WriteLine(comparacion);
            //Console.WriteLine(persona.ToString());
            //Console.WriteLine(persona.MostrarDatos());
            //Console.WriteLine(persona2.MostrarDatos());

            //Persona persona3 = new Persona(1, "Perez", "Jose"); 
            //Persona persona4 = new Persona(1, "Perez", "Ramon");
            

            //string resultadoSumaPersonas = persona3 + persona4;
            //Console.WriteLine(resultadoSumaPersonas);

            //Persona p = persona+10;
       
            //Console.WriteLine(persona.MostrarDatos());

            //int edad = persona;

            //Console.WriteLine($"El resultado de la conversion implicita es {edad}");
            //persona.nombre = "Alejandro";
            //string nombre = (string)persona;
            //Console.WriteLine($"El resultado de la conversion explicita es {nombre}");


            Persona personaConNombre = "Pepe";

            Console.WriteLine((string)personaConNombre);

            Persona personaConDni = 12345678;

            
            Console.WriteLine((string)personaConDni);

        }
    }
}