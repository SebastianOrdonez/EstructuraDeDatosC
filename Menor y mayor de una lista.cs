using System;
using System.Collections.Generic;
using System.Linq;

class Precios {
    public List<int> Lista { get; set; }

    public Precios(List<int> lista) {
        Lista = lista;
    }

    public void MostrarMinMax() {
        Console.WriteLine($"Menor: {Lista.Min()}  Mayor: {Lista.Max()}");
    }
}

class Program {
    static void Main() {
        Precios p = new Precios(
            new List<int>{50,75,46,22,80,65,8}
        );
        p.MostrarMinMax();
    }
}
