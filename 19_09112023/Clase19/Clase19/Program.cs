using Entidades;

namespace Clase19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region "Codigo comentado"
            //Action action = () => { Reloj(DateTime.Now); };
            //Task tareaHiloSec = new Task(action);



            //Task.Run(() =>
            //{
            //    while (true)
            //    {
            //        Reloj(DateTime.Now);    
            //    }
            //});

            //Task.Run(MetodoSinParametros);

            //Console.ReadKey();

            //Task tareaHiloSec = new Task(() => { Reloj(DateTime.Now); });


            //tareaHiloSec.Start();

            //ConsoleKey teclaPresionada;

            //do
            //{
            //    teclaPresionada= Console.ReadKey().Key;
            //    Console.WriteLine($"Presiono {teclaPresionada}");
            //    if(teclaPresionada == ConsoleKey.Spacebar)
            //    {
            //        break;
            //    }

            //} while (true);

            //Console.WriteLine("El main principal finalizo");

            #endregion

            //Negocio  n = new Negocio();

            //n.AbrirNegocio(p=> Console.WriteLine(p.ToString()));


            Persona p = new Persona();
            p.Apellido = "Perez";
            p.Nombre = "Jose";


            Persona p1 = p.Clone() as Persona;

            p1.Apellido = "Perez1";
            p1.Nombre = "Jose1";

            Console.WriteLine(p.ToString());
            Console.WriteLine(p1.ToString());


            Console.ReadKey();

        }

        #region "Metodo comentado"
        //static void Reloj(DateTime dateTime)
        //{
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //    Console.WriteLine(Task.CurrentId);
        //    Console.WriteLine($"tiempo transcurrido {dateTime}");
        //    Thread.Sleep(1000);

        //}

        //static void MetodoSinParametros()
        //{

        //    while(true)
        //    {
        //        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //        Console.WriteLine(Task.CurrentId);
        //        Console.WriteLine($"tiempo transcurrido en metodo Sin parametros {DateTime.Now}");
        //        Thread.Sleep(1000);


        //    }

        //}
        #endregion


    }
}