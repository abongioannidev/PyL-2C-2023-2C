namespace MetodosGenericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClaseNormal claseNormal = new ClaseNormal();
            claseNormal.MetodoGenerico("Hola mundo");
            /*Console.WriteLine("Hello, World!")*/
            ;
        }
    }


    public class ClaseNormal
    {

        public void MetodoGenerico<T>(T valor) where T : class
        {
            Console.WriteLine(valor);
        }

    }

    public class ClaseGenerica<T>
    {
        public void MetodoGenerico(T valor)
        {
            Console.WriteLine(valor);
        }
    }
}