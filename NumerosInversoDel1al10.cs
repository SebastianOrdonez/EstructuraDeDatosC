using System;

class Secuencia {
    public static void Inverso() {
        for (int i = 10; i >= 1; i--) {
            Console.Write(i + (i > 1 ? ", " : ""));
        }
        Console.WriteLine();
    }
}

class Program {
    static void Main() {
        Secuencia.Inverso();
    }
}
