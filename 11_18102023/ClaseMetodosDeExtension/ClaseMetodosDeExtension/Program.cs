using Entidades;
using CalculadoraCompilada;
namespace ClaseMetodosDeExtension
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            EAlgo algo = EAlgo.Algo;

            algo.MetodoDelEnum();
            //List<int> list = new List<int>() { 1, 2, 4, 5, 6, 765, 123, 90, 12 };

            //list.Ordenar(false); ;


            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            Calculadora c = new Calculadora(1, 2);



            Console.WriteLine();


            

        }
    }
}