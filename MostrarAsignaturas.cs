using System;
using System.Collections.Generic;

class Curso {
    public List<string> Asignaturas { get; set; }

    public Curso(List<string> asignaturas) {
        Asignaturas = asignaturas;
    }

    public void Mostrar() {
        foreach (string a in Asignaturas) {
            Console.WriteLine(a);
        }
    }
}

class Program {
    static void Main() {
        Curso curso = new Curso(new List<string>{
            "Matemáticas","Física","Química","Historia","Lengua"
        });
        curso.Mostrar();
    }
}
