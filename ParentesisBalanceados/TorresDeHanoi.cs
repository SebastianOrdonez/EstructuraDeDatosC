using System;
using System.Collections.Generic;

class TorresDeHanoiConPilas
{
    static int paso = 0;

    static void Main()
    {
        int n = 3; // Cambia el número de discos si deseas

        Stack<int> A = new Stack<int>();
        Stack<int> B = new Stack<int>();
        Stack<int> C = new Stack<int>();

        // Inicializamos la torre A con n discos (n abajo ... 1 arriba)
        for (int i = n; i >= 1; i--)
            A.Push(i);

        Console.WriteLine("Estado inicial:");
        ImprimirTorres(A, B, C);

        // Resolver: mover n discos de A a C usando B
        Hanoi(n, A, C, B, "A", "C", "B");

        Console.WriteLine("\nEstado final:");
        ImprimirTorres(A, B, C);
    }

    // Algoritmo de Hanoi: mueve n discos desde origen -> destino usando auxiliar
    static void Hanoi(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar,
                      string nombreOrigen, string nombreDestino, string nombreAuxiliar)
    {
        if (n == 1)
        {
            MoverDisco(origen, destino, nombreOrigen, nombreDestino);
            return;
        }

        // 1) mover n-1 de origen a auxiliar usando destino
        Hanoi(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);

        // 2) mover el disco grande (n) de origen a destino
        MoverDisco(origen, destino, nombreOrigen, nombreDestino);

        // 3) mover n-1 de auxiliar a destino usando origen
        Hanoi(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
    }

    static void MoverDisco(Stack<int> origen, Stack<int> destino, string from, string to)
    {
        // Validación por seguridad (regla: no grande sobre pequeño)
        int disco = origen.Pop();

        if (destino.Count > 0 && destino.Peek() < disco)
            throw new InvalidOperationException("Movimiento inválido: disco grande sobre disco pequeño.");

        destino.Push(disco);

        paso++;
        Console.WriteLine($"\nPaso {paso}: Mover disco {disco} de {from} -> {to}");
    }

    static void ImprimirTorres(Stack<int> A, Stack<int> B, Stack<int> C)
    {
        Console.WriteLine($"Torre A: {StackToString(A)}");
        Console.WriteLine($"Torre B: {StackToString(B)}");
        Console.WriteLine($"Torre C: {StackToString(C)}");
    }

    static string StackToString(Stack<int> torre)
    {
        // Stack se enumera de arriba hacia abajo, lo mostramos así para que sea claro
        if (torre.Count == 0) return "(vacía)";
        return string.Join(", ", torre); 
    }
}
