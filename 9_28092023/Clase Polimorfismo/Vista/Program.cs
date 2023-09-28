using Entidades;
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Alumno alumno = new Alumno("Juan", "Perez", 22222222, "11122");
            Profesor profe = new Profesor("Ale", "Bongioanni", 33333333, "Progra y Labo II");
            Persona persona = profe;
            List<Persona> lista = new List<Persona>();

            lista.Add(alumno); 
            lista.Add(profe);

            alumno.Mostrar();

            foreach (Persona p in lista)
            {
                //if (p is Alumno a)
                //{
                //    Console.WriteLine(a.Mostrar());
                //}
                //else if (p is Profesor pr)
                //{
                //    Console.WriteLine(pr.Mostrar());
                //}
                Console.WriteLine(p.Mostrar());
                Console.WriteLine("***********************");
                Console.WriteLine(p.Saludar());
                Console.WriteLine("***********************\n\n");
            }
        }
    }
}