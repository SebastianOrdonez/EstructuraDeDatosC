using System;

ListaEnlazada lista = new ListaEnlazada();

lista.Insertar(10);
lista.Insertar(20);
lista.Insertar(30);
lista.Insertar(40);
lista.Insertar(50);

Console.WriteLine("Lista original:");
lista.Mostrar();

int total = lista.ContarElementos();
Console.WriteLine("\nNúmero de elementos: " + total);

lista.Invertir();
Console.WriteLine("\nLista invertida:");
lista.Mostrar();

Console.ReadKey();
