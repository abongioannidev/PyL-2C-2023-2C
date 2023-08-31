namespace Clase01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primerNumero = 10;
            int segundoNumero = 10;


            //int resultado = primerNumero + segundoNumero;

            //string primerSaludo = "Hola";
            //string segundoSaludo = " Mundo";

            //string resultadoString = primerSaludo + segundoSaludo;


            //Console.WriteLine(resultado);
            //Console.WriteLine(resultadoString);
            //Console.WriteLine(resultadoString + ' ' + resultado);

            //primerNumero ++;
            //Console.WriteLine(primerNumero);
            //primerNumero --;
            //Console.WriteLine(primerNumero);


            //resultado = primerNumero--;
            //Console.WriteLine(resultado);
            //resultado = --primerNumero;
            //Console.WriteLine(resultado);


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);

            //}

            //int contador = 0;
            //do
            //{
            //    contador++;
            //    Console.WriteLine(contador);
            //}while (contador <10);
            //string saludo = "Hola Mundo";
            //string[] saludos = new string [] { "Hola", "Como Estas", "Pepe", "Uriel" };
            //foreach (char caracter in saludo)
            //{
            //    Console.WriteLine(caracter);

            //}
            //foreach (string item in saludos)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("fjsdjdsf");
            //Console.Title = "Consola de Alejandro";
            //Console.WriteLine("Ingresame un dato:");
            //string ingreso = Console.ReadLine();

            float precio = 500.5645465465f;

            Console.WriteLine("El precio es {0, 20:#.#}", precio);
            Console.WriteLine($"El precio es {precio.ToString("0.00")}");

            //void ImprimirPorPantalla(string mensaje)
            //{
            //    Console.WriteLine("El mensaje recibido es {0} {1}",mensaje);
            //    Console.WriteLine($"El mensaje con string interpolado es {mensaje}");
            //}

            //int DevuelveAlgo()
            //{
            //    return 900;
            //}





        }


    }
}