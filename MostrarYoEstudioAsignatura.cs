using System;
using System.Collections.Generic;

class Estudiante {
    public List<string> Materias { get; set; }
    public Estudiante(List<string> materias) {
        Materias = materias;
    }

    public void MostrarEstudios() {
        foreach (string m in Materias) {
            Console.WriteLine($"Yo estudio {m}");
        }
    }
}

class Program {
    static void Main() {
        Estudiante est = new Estudiante(new List<string>{
            "Matemáticas","Física","Química","Historia","Lengua"
        });
        est.MostrarEstudios();
    }
}
