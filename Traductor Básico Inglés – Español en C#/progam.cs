using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Traductor
{
    static string rutaArchivo = "diccionario.txt";

    static void Main(string[] args)
    {
        Dictionary<string, string> inglesEspanol = 
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        Dictionary<string, string> espanolIngles = 
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        // Cargar palabras guardadas
        CargarDiccionario(inglesEspanol, espanolIngles);

        int opcion;

        do
        {
            Console.WriteLine("\n==================== MENÚ ====================");
            Console.WriteLine("1. Traducir Inglés ➜ Español");
            Console.WriteLine("2. Traducir Español ➜ Inglés");
            Console.WriteLine("3. Agregar palabra");
            Console.WriteLine("0. Salir");
            Console.Write("\nSeleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TraducirFrase(inglesEspanol);
                    break;

                case 2:
                    TraducirFrase(espanolIngles);
                    break;

                case 3:
                    AgregarPalabra(inglesEspanol, espanolIngles);
                    break;
            }

        } while (opcion != 0);
    }

    static void CargarDiccionario(Dictionary<string, string> ingEsp,
                                  Dictionary<string, string> espIng)
    {
        if (File.Exists(rutaArchivo))
        {
            string[] lineas = File.ReadAllLines(rutaArchivo);

            foreach (string linea in lineas)
            {
                string[] partes = linea.Split(',');

                if (partes.Length == 2)
                {
                    string ingles = partes[0];
                    string espanol = partes[1];

                    ingEsp[ingles] = espanol;
                    espIng[espanol] = ingles;
                }
            }
        }
    }

    static void AgregarPalabra(Dictionary<string, string> ingEsp,
                               Dictionary<string, string> espIng)
    {
        Console.Write("\nIngrese palabra en inglés: ");
        string ingles = Console.ReadLine().ToLower();

        Console.Write("Ingrese palabra en español: ");
        string espanol = Console.ReadLine().ToLower();

        if (!ingEsp.ContainsKey(ingles))
        {
            ingEsp[ingles] = espanol;
            espIng[espanol] = ingles;

            // Guardar en archivo
            File.AppendAllText(rutaArchivo, ingles + "," + espanol + Environment.NewLine);

            Console.WriteLine("Palabra guardada permanentemente ✅");
        }
        else
        {
            Console.WriteLine("La palabra ya existe.");
        }
    }

    static void TraducirFrase(Dictionary<string, string> diccionario)
    {
        Console.Write("\nIngrese una frase: ");
        string frase = Console.ReadLine();

        string resultado = Regex.Replace(frase, @"\b\w+\b", palabra =>
        {
            if (diccionario.ContainsKey(palabra.Value))
                return diccionario[palabra.Value];

            return palabra.Value;
        });

        Console.WriteLine("\nTraducción:");
        Console.WriteLine(resultado);
    }
}