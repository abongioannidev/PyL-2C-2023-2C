using Entidades;

using System.Collections.Generic;
using System.Security.Cryptography;

namespace Clase_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            const int FILAS = 3;
            const int COLUMNAS = 2;
            string[,] nombresCompletos = new string[FILAS, COLUMNAS] { {"Lucas", "Ferrini" },
                                                                      {"Ale", "Bongioanni"},
                                                                      {"Pepe", "Martinez"}};
            string[][] matrizEscalonada = new string[3][];

            matrizEscalonada[0] = new string[5];
            matrizEscalonada[1] = new string[3];
            matrizEscalonada[2] = new string[8];

            matrizEscalonada[0][0] = "Hola Mundo";


            Console.WriteLine(nombresCompletos[0,1]);
            Console.WriteLine(matrizEscalonada[0][0]);
            */

            //Lista
            //List<int> listaNumeros = new List<int>();

            //listaNumeros.Add(1); //Indice 0
            //listaNumeros.Add(2); //Indice 1
            //listaNumeros.Add(3); //Indice 2

            //foreach (int numero in listaNumeros)
            //{
            //    Console.WriteLine(numero);
            //}

            //listaNumeros.Insert(0, 4);
            //listaNumeros.Add(4);
            //Console.WriteLine("----------------------------------");
            //foreach (int numero in listaNumeros)
            //{
            //    Console.WriteLine(numero);
            //}
            //Console.WriteLine(listaNumeros.IndexOf(2));

            //Recordar que Contains compara por referencia usando Equals cuando
            //trabajamos con objetos
            //Console.WriteLine(listaNumeros.Contains(2));

            //listaNumeros.Remove(4);




            //foreach (int numero in listaNumeros)
            //{
            //    Console.WriteLine(numero);
            //}
            //Console.WriteLine("Cantidad de numeros:");
            //Console.WriteLine(listaNumeros.Count);

            //for(int i = 0; i < listaNumeros.Count; i++)
            //{
            //    Console.WriteLine(listaNumeros[i]);
            //}
            //Console.WriteLine("Elimino el indice 2");


            //listaNumeros.RemoveAt(2);
            //listaNumeros.RemoveRange(0, 2);
            //for (int i = 0; i < listaNumeros.Count; i++)
            //{
            //    Console.WriteLine(listaNumeros[i]);
            //}

            //Console.WriteLine("Ejecuto un clear");
            //listaNumeros.Clear();

            //foreach(int numero in listaNumeros)
            //{
            //    Console.WriteLine(numero);
            //}

            //for(int i = 0;i < listaNumeros.Count;i++)
            //{
            //    listaNumeros[i] = listaNumeros[i] * listaNumeros[i];
            //    Console.WriteLine(listaNumeros[i]);
            //}

            //Diccionarios
            //         clave   valor
            //Dictionary<string, string> comidasPorPais = new Dictionary<string, string>();

            //comidasPorPais.Add("Mexico", "Tacos");
            //comidasPorPais.Add("Italia", "Pizza");
            //comidasPorPais.Add("Argentina", "Asado");
            //comidasPorPais.Add("Argentina", "Fernet");


            //comidasPorPais.Remove("Mexico");



            //Console.WriteLine(comidasPorPais.ContainsKey("Mexico"));
            //Console.WriteLine(comidasPorPais.ContainsValue("Pizza"));

            //foreach(var par in comidasPorPais)
            //foreach(KeyValuePair<string, string> par in comidasPorPais)
            //{
            //    Console.WriteLine($"La clave es {par.Key} y el valor es {par.Value}");
            //}

            //bool pudoAgregar = comidasPorPais.TryAdd("Argentina", "Fernet");
            //Console.WriteLine(pudoAgregar);

            //Colas


            //FIFO - First In, First Out
            //Queue<int> colaEnteros = new Queue<int>();

            //colaEnteros.Enqueue(1);
            //colaEnteros.Enqueue(2);
            //colaEnteros.Enqueue(3);
            //colaEnteros.Enqueue(4);

            //Console.WriteLine("Cantidad de elementos en cola");
            //Console.WriteLine(colaEnteros.Count);

            //Console.WriteLine(colaEnteros.Peek());
            //Console.WriteLine(colaEnteros.Peek());
            //Console.WriteLine(colaEnteros.Peek());

            //Console.WriteLine("Cantidad de elementos en cola");
            //Console.WriteLine(colaEnteros.Count);
            //Console.WriteLine(colaEnteros.Dequeue());
            //Console.WriteLine("Cantidad de elementos en cola");
            //Console.WriteLine(colaEnteros.Count);
            //Console.WriteLine(colaEnteros.Dequeue());
            //Console.WriteLine("Cantidad de elementos en cola");
            //Console.WriteLine(colaEnteros.Count);
            //Console.WriteLine(colaEnteros.Dequeue());
            //Console.WriteLine("Cantidad de elementos en cola");
            //Console.WriteLine(colaEnteros.Count);
            //Console.WriteLine(colaEnteros.Dequeue());
            //Console.WriteLine("Cantidad de elementos en cola");
            //Console.WriteLine(colaEnteros.Count);
            //if(colaEnteros.Count > 0)
            //{
            //    Console.WriteLine(colaEnteros.Peek());
            //}

            //Pilas o stack
            //

            //LIFO - Last In, First Out
            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);

            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Peek());

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            //foreach (int i in stack)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(stack[2]);
            
            List<Persona> lista = new List<Persona>();
            lista.Add(new Persona(22222222, "Peter", "Capusotto"));
            lista.Add(new Persona(11111111, "Coco", "Basile"));
            lista.Add(new Persona(33333333, "Ankara", "Messi"));

            Persona capusotto = new Persona(22222222, "Peter", "Capusotto");

            Console.WriteLine(lista.Contains(capusotto));

        }
    }
}