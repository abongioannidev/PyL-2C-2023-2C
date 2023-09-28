using Entidades;
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona persona = new Persona("Lucas", "Ferrini", 11111111);
            Persona persona;
            Alumno alumno = new Alumno("Juan", "Perez", 22222222, "11122");
            Profesor profe = new Profesor("Ale", "Bongioanni", 33333333, "Progra y Labo II");

            List<Persona> lista = new List<Persona>();

            lista.Add(alumno); 
            lista.Add(profe);

            //persona = alumno;

            foreach(Persona p in lista)
            {
                //if(p is Alumno)
                //{
                //    Console.WriteLine(((Alumno)p).Mostrar());

                //}
                //else if(p is Profesor)
                //{
                //    Console.WriteLine(((Profesor)p).Mostrar());

                //}

                //if (p is Alumno a)
                //{
                //    Console.WriteLine(a.Mostrar());

                //}
                //else if (p is Profesor pr)
                //{
                //    Console.WriteLine(pr.Mostrar());

                //}

                //Console.WriteLine(p.Mostrar());
            }

            object saludo = "Hola mundo";

            Console.WriteLine(((Alumno)saludo).Mostrar());



            //saludo.Length;

            //saludo.


            //Console.WriteLine(alumno.MostrarPersona());


            //Console.WriteLine(persona.MostrarDatos());
            //Console.WriteLine(((Alumno)persona).Legajo);
        }
    }
}