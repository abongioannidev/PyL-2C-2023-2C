using System.IO;
using System.Text.Json;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Path.DirectorySeparatorChar);
            //string path = Path.Combine(@"C:\Users\lucas\OneDrive\Escritorio\Clase Archivos\", "Archivo.txt");
            //Console.WriteLine(path);
            //Console.WriteLine(Directory.GetCurrentDirectory());

            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //path = Path.Combine(path, "Clase Archivos");

            //Directory.Delete(path + @"\Directorio 2");

            //Console.WriteLine("Borre el directorio 2");

            //Console.WriteLine(Directory.Exists(path + @"\Directorio 2"));
            //Directory.Delete(path + @"\Directorio 1");

            //string nombreCarpeta = "Directorio 1";
            //string rutaCompleta = Path.Combine(path, nombreCarpeta);

            //if(!Directory.Exists(rutaCompleta)) 
            //{ 
            //    Directory.CreateDirectory(rutaCompleta);
            //}

            //string nombreArchivo = "Mi Archivo de texto.txt";

            //rutaCompleta = Path.Combine(path, nombreArchivo);
            //using (StreamWriter sw = new StreamWriter(rutaCompleta))
            //{
            //    sw.WriteLine("Hola desde mi aplicacion de C#");
            //}

            //using (StreamWriter sw = new StreamWriter(rutaCompleta, true))
            //{
            //    sw.WriteLine("Hola desde mi aplicacion de C# desde mi segundo using");
            //}

            //using(StreamReader sr = new StreamReader(rutaCompleta))
            //{
            //    string linea = "";
            //    while(linea != null)
            //    {
            //        linea = sr.ReadLine();
            //        Console.WriteLine(linea);
            //    }
            //}

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = Path.Combine(path, "Clase Archivos");

            string archivoJson = "Persona.json";

            string rutaCompleta = Path.Combine(path, archivoJson);

            Persona lucas = new Persona("Lucas", "Ferrini", 11112222);
            Persona ale = new Persona("Ale", "Bongioanni", 22221111);

            List<Persona> lista = new List<Persona>();
            lista.Add(lucas);
            lista.Add(ale);

            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            //using (StreamWriter sw = new StreamWriter(rutaCompleta))
            //{
            //    string lucasJson = JsonSerializer.Serialize(lucas, options);
            //    sw.WriteLine(lucasJson);
            //}

            using (StreamWriter sw = new StreamWriter(rutaCompleta))
            {
                string listaJson = JsonSerializer.Serialize(lista, options);
                sw.WriteLine(listaJson);
            }

            List<Persona> personas;

            using (StreamReader sr = new StreamReader(rutaCompleta))
            {
                string listaJson = sr.ReadToEnd();
                personas = JsonSerializer.Deserialize<List<Persona>>(listaJson);
            }

            foreach (var persona in personas)
            {
                Console.WriteLine(persona.Nombre);
                Console.WriteLine(persona.Apellido);
                Console.WriteLine(persona.Dni);
                Console.WriteLine("**************************");
            }

            //Persona alguien;

            //using (StreamReader sr = new StreamReader(rutaCompleta))
            //{
            //    string jsonString = sr.ReadToEnd();
            //    alguien = JsonSerializer.Deserialize<Persona>(jsonString);
            //}
            //Console.WriteLine(alguien.Nombre);
            //Console.WriteLine(alguien.Apellido);
            //Console.WriteLine(alguien.Dni);
            //foreach(string cosa in lucas.Cosas)
            //{
            //    Console.WriteLine(cosa);
            //}


            //PersonaModelo persona2 = new PersonaModelo();

            //persona2.Nombre = "Ramon";

            //Console.WriteLine(persona2.Nombre);
        }
    }
}