using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, (string autor, int anio)> libros = new Dictionary<string, (string, int)>();
    static HashSet<string> titulos = new HashSet<string>();

    static void RegistrarLibro()
    {
        Console.Write("Ingrese el título del libro: ");
        string titulo = Console.ReadLine();

        if (titulos.Contains(titulo))
        {
            Console.WriteLine("El libro ya está registrado.");
            return;
        }

        Console.Write("Ingrese el autor: ");
        string autor = Console.ReadLine();

        Console.Write("Ingrese el año de publicación: ");
        int anio = int.Parse(Console.ReadLine());

        libros[titulo] = (autor, anio);
        titulos.Add(titulo);

        Console.WriteLine("Libro registrado correctamente.");
    }

    static void MostrarLibros()
    {
        if (libros.Count == 0)
        {
            Console.WriteLine("No hay libros registrados.");
            return;
        }

        Console.WriteLine("\nLista de libros registrados:");

        foreach (var libro in libros)
        {
            Console.WriteLine($"Título: {libro.Key} | Autor: {libro.Value.autor} | Año: {libro.Value.anio}");
        }
    }

    static void BuscarLibro()
    {
        Console.Write("Ingrese el título del libro a buscar: ");
        string titulo = Console.ReadLine();

        if (libros.ContainsKey(titulo))
        {
            var datos = libros[titulo];

            Console.WriteLine("\nLibro encontrado:");
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Autor: {datos.autor}");
            Console.WriteLine($"Año: {datos.anio}");
        }
        else
        {
            Console.WriteLine("Libro no encontrado.");
        }
    }

    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.WriteLine("\n--- SISTEMA DE BIBLIOTECA ---");
            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Mostrar libros");
            Console.WriteLine("3. Buscar libro");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    RegistrarLibro();
                    break;

                case 2:
                    MostrarLibros();
                    break;

                case 3:
                    BuscarLibro();
                    break;

                case 4:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 4);
    }
}