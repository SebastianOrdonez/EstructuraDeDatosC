// Librerías necesarias para entrada/salida y manejo de archivos
using System;
using System.IO;

// Estructura que representa un contacto de la agenda
// Agrupa datos relacionados: nombre y teléfono
struct Contacto
{
    public string Nombre;
    public string Telefono;
}

class AgendaTelefonica
{
    // Vector que almacena los contactos en memoria
    static Contacto[] agenda = new Contacto[100];

    // Contador que indica cuántos contactos han sido registrados
    static int contador = 0;

    // Nombre del archivo donde se guardan los registros
    static string archivo = "agenda.txt";

    // Método que carga los contactos desde el archivo al iniciar el programa
    static void CargarContactos()
    {
        // Verifica si el archivo existe
        if (File.Exists(archivo))
        {
            // Lee todas las líneas del archivo
            string[] lineas = File.ReadAllLines(archivo);

            // Recorre cada línea del archivo
            foreach (string linea in lineas)
            {
                // Separa los datos usando el carácter ;
                string[] datos = linea.Split(';');

                // Asigna los datos al vector de contactos
                agenda[contador].Nombre = datos[0];
                agenda[contador].Telefono = datos[1];

                // Incrementa el contador de contactos
                contador++;
            }
        }
    }

    // Método que guarda un contacto nuevo en el archivo
    static void GuardarContacto(Contacto c)
    {
        // Abre el archivo en modo agregar (append)
        using (StreamWriter sw = new StreamWriter(archivo, true))
        {
            // Escribe el contacto en una nueva línea
            sw.WriteLine($"{c.Nombre};{c.Telefono}");
        }
    }

    // Método que permite agregar un nuevo contacto a la agenda
    static void AgregarContacto()
    {
        // Verifica que el vector no esté lleno
        if (contador < agenda.Length)
        {
            // Crea un nuevo contacto
            Contacto nuevo;

            // Solicita el nombre del contacto
            Console.Write("Nombre: ");
            nuevo.Nombre = Console.ReadLine();

            // Solicita el número telefónico
            Console.Write("Teléfono: ");
            nuevo.Telefono = Console.ReadLine();

            // Guarda el contacto en el vector
            agenda[contador] = nuevo;

            // Incrementa el contador
            contador++;

            // Guarda el contacto en el archivo
            GuardarContacto(nuevo);

            // Mensaje de confirmación
            Console.WriteLine("Contacto guardado correctamente.\n");
        }
        else
        {
            // Mensaje si la agenda está llena
            Console.WriteLine("La agenda está llena.\n");
        }
    }

    // Método que muestra todos los contactos almacenados
    static void MostrarContactos()
    {
        Console.WriteLine("\nLISTA DE CONTACTOS:");

        // Recorre el vector hasta el número de contactos registrados
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine($"Nombre: {agenda[i].Nombre} - Teléfono: {agenda[i].Telefono}");
        }

        Console.WriteLine();
    }

    // Método principal del programa
    static void Main()
    {
        // Carga los contactos almacenados previamente
        CargarContactos();

        int opcion;

        // Menú principal del sistema
        do
        {
            Console.WriteLine("AGENDA TELEFÓNICA");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Mostrar contactos");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            // Ejecuta la opción seleccionada
            switch (opcion)
            {
                case 1:
                    AgregarContacto();
                    break;

                case 2:
                    MostrarContactos();
                    break;
            }

        } while (opcion != 3); // Finaliza cuando el usuario selecciona salir
    }
}
