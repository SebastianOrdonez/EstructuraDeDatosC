using System;
using System.Collections.Generic;
using System.Linq;

class Loteria {
    public List<int> Numeros { get; set; }

    public void Pedir() {
        Console.WriteLine("Ingresa 6 números ganadores:");
        Numeros = new List<int>();
        for (int i = 0; i < 6; i++) {
            Console.Write($"Número {i+1}: ");
            Numeros.Add(int.Parse(Console.ReadLine()));
        }
    }

    public void MostrarOrdenados() {
        foreach (int n in Numeros.OrderBy(x => x)) {
            Console.WriteLine(n);
        }
    }
}

class Program {
    static void Main() {
        Loteria lot = new Loteria();
        lot.Pedir();
        Console.WriteLine("Números ordenados:");
        lot.MostrarOrdenados();
    }
}
