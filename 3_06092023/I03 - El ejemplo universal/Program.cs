using Entidades;

namespace I03___El_ejemplo_universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Marguery", "Lautaro", "123456");
            Estudiante e2 = new Estudiante("Marles", "Uriel" ,"222222");
            Estudiante e3 = new Estudiante("Perez", "Juan", "111111");

            e1.SetNotaPrimerParcial(7);
            e1.SetNotaSegundoParcial(9); 

            e2.SetNotaPrimerParcial(4);
            e2.SetNotaSegundoParcial(10);

            e3.SetNotaPrimerParcial(2);
            e3.SetNotaSegundoParcial(5);


            Console.WriteLine(e1.Mostrar());
            Console.WriteLine(e2.Mostrar());
            Console.WriteLine(e3.Mostrar());

        }
    }
}