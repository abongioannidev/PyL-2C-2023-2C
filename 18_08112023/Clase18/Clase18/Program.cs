using Entidades;
using System.Linq;

namespace Clase18
{
    public delegate void DelegadoNotificacion(string mensaje);
    public delegate int DelegadoNumerico(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<Persona> list = new List<Persona>()
            //{
            //    new Persona() {Nombre= "German" ,Apellido="Cano", Edad=32},
            //    new Persona() {Nombre= "Felipe" ,Apellido="Melo", Edad=40},
            //    new Persona() {Nombre= "John" ,Apellido="Kennedy",Edad=22},

            //        new Persona() {Nombre= "Colo" ,Apellido="Barco",Edad=18},


            //};

            //var personas = list.FindAll(p => p.Edad > 20);



            //var personas2 = list.Where(p => p.Edad > 20);


            //foreach (var item in personas)
            //{
            //    Console.WriteLine($"{item.Apellido}, {item.Nombre}, {item.Edad}");
            //}


            //DelegadoNotificacion ejemplo = (algo) =>
            //{
            //    Console.WriteLine(algo);
            //};

            //ejemplo("Hola Mundo");



            //Persona p = list.Find(BuscarPersona);


            //Console.WriteLine($"{p.Apellido}, {p.Nombre}, {p.Edad}");



            ListaEnlazada<Persona> listaEnlazadaPersonas = new ListaEnlazada<Persona>();

            listaEnlazadaPersonas.AgregarElemento(new Persona() { Nombre = "German", Apellido = "Cano", Edad = 32 });
            listaEnlazadaPersonas.AgregarElemento(new Persona() { Nombre = "Felipe", Apellido = "Melo", Edad = 40 });
            listaEnlazadaPersonas.AgregarElemento(new Persona() { Nombre = "John", Apellido = "Kennedy", Edad = 22 });




            //Persona p = listaEnlazadaPersonas.Buscar(p => p.Edad == 22);


            //Console.WriteLine($"{p.Apellido}, {p.Nombre}, {p.Edad}");

            Console.WriteLine(listaEnlazadaPersonas.IndiceDe(p => p.Edad == 40));


            //ListaEnlazada<string> lista = new ListaEnlazada<string>();

            //lista.AgregarElemento("Hola Mundo"); 
            //lista.AgregarElemento("Como estas");
            //lista.AgregarElemento("Todo Bien");




            //Console.WriteLine(lista[0]);
            //Console.WriteLine(lista[1]);


            //DelegadoNotificacion miDelegado = ImprimirMensaje;
            //miDelegado += ImprimirMensaje2;




            //miDelegado("HOLA DESDE EL DELEGADO");
            //miDelegado("Otra cosa distinta");

            //DelegadoNumerico delegadoCalculador = new DelegadoNumerico(Sumar);

            //delegadoCalculador += Restar;

            //delegadoCalculador += Multiplicar;

            //int resultado = delegadoCalculador(10, 5);

            //Console.WriteLine(resultado);


            //foreach (DelegadoNumerico item in delegadoCalculador.GetInvocationList())
            //{
            //    int res = item(10, 5);
            //    Console.WriteLine(res);

            //}

            //Func<int> delegadoQueNoRecibeParametosYRetornaInt = HacerAlgoFunc;
            //Func<string, int> delegagoStringInt = HacerAlgoFunc2;

            //Action noRecibeParamYNoRetorna = NoRecibeNoRetorna;

            //Predicate<int> recibeIntRetornaBool = RecibeIntYRetornaBool;

        }



        //static void ImprimirMensaje(string mensaje)
        //{
        //    Console.WriteLine(mensaje);

        //}
        //static void ImprimirMensaje2(string mensaje)
        //{
        //    Console.WriteLine($" desde el segundo metodo {mensaje}");

        //}

        //static int Sumar(int a, int b)
        //{
        //    return a + b;
        //}

        //static int Restar(int a, int b)
        //{
        //    return a - b;
        //}
        //static int Multiplicar(int a, int b)
        //{
        //    return a * b;
        //}
        //static int HacerAlgoFunc()
        //{
        //    return 0;
        //}
        //static int HacerAlgoFunc2(string algo)
        //{
        //    return algo.Length;
        //}

        //static void NoRecibeNoRetorna()
        //{

        //}
        //static bool RecibeIntYRetornaBool(int a)
        //{
        //    return a == 10;
        //}

        //static bool BuscarPersona(Persona persona)
        //{
        //    return persona.Edad > 67;
        //}

       
    }
}