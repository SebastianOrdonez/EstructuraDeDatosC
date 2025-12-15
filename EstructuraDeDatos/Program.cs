using System;
using System.IO;

class Estudiante
{
    public int Id;
    public string Nombres;
    public string Apellidos;
    public string Direccion;
    public string[] Telefonos;

    public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
    {
        Id = id;
        Nombres = nombres;
        Apellidos = apellidos;
        Direccion = direccion;
        Telefonos = telefonos;
    }

    public void GuardarEnArchivo()
    {
        using (StreamWriter sw = new StreamWriter("estudiante.txt", true))
        {
            sw.WriteLine("ID: " + Id);
            sw.WriteLine("Nombres: " + Nombres);
            sw.WriteLine("Apellidos: " + Apellidos);
            sw.WriteLine("Dirección: " + Direccion);
            sw.WriteLine("Teléfonos: " + string.Join(", ", Telefonos));
            sw.WriteLine("-----------------------------------");
        }
    }

    public static void MostrarDesdeArchivo()
    {
        if (File.Exists("estudiante.txt"))
        {
            Console.WriteLine("\n=== REGISTROS GUARDADOS ===");
            Console.WriteLine(File.ReadAllText("estudiante.txt"));
        }
        else
        {
            Console.WriteLine("No existen registros guardados.");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== REGISTRO DE ESTUDIANTE ===");

        Estudiante.MostrarDesdeArchivo();

        Console.Write("Ingrese ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Ingrese nombres: ");
        string nombres = Console.ReadLine();

        Console.Write("Ingrese apellidos: ");
        string apellidos = Console.ReadLine();

        Console.Write("Ingrese dirección: ");
        string direccion = Console.ReadLine();

        string[] telefonos = new string[3];

        for (int i = 0; i < telefonos.Length; i++)
        {
            Console.Write($"Ingrese teléfono {i + 1}: ");
            telefonos[i] = Console.ReadLine();
        }

        Estudiante estudiante = new Estudiante(id, nombres, apellidos, direccion, telefonos);
        estudiante.GuardarEnArchivo();

        Console.WriteLine("\nDatos guardados correctamente.");
        Console.ReadKey();
    }
}
