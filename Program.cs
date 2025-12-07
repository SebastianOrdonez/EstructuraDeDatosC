using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Cálculo de Figuras Geométricas ===");
        Console.WriteLine("1. Círculo");
        Console.WriteLine("2. Rectángulo");
        Console.Write("Seleccione una figura (1-2): ");
        string opcion = Console.ReadLine();

        if (opcion == "1")
        {
            // --- Lógica del Círculo ---
            Console.Write("Ingrese el radio del círculo: ");
            
            // Validar la entrada antes de convertir, por seguridad
            if (double.TryParse(Console.ReadLine(), out double radio))
            {
                // Crear objeto Circulo (la clase está en Circulo.cs)
                Circulo c = new Circulo(radio);

                // Mostrar resultados con 2 decimales (:F2)
                Console.WriteLine($"Área: {c.CalcularArea():F2}");
                Console.WriteLine($"Perímetro: {c.CalcularPerimetro():F2}");
            }
            else
            {
                Console.WriteLine("Entrada inválida para el radio.");
            }
        }
        else if (opcion == "2")
        {
            // --- Lógica del Rectángulo ---
            Console.Write("Ingrese el ancho del rectángulo: ");
            if (double.TryParse(Console.ReadLine(), out double ancho))
            {
                Console.Write("Ingrese el alto del rectángulo: ");
                if (double.TryParse(Console.ReadLine(), out double alto))
                {
                    // Crear objeto Rectangulo (la clase está en Rectangulo.cs)
                    Rectangulo r = new Rectangulo(ancho, alto);

                    // Mostrar resultados con 2 decimales (:F2)
                    Console.WriteLine($"Área: {r.CalcularArea():F2}");
                    Console.WriteLine($"Perímetro: {r.CalcularPerimetro():F2}");
                }
                else
                {
                    Console.WriteLine("Entrada inválida para el alto.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida para el ancho.");
            }
        }
        else
        {
            Console.WriteLine("Opción inválida. Debe seleccionar 1 o 2.");
        }

        // Evita que la ventana de la consola se cierre inmediatamente
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}