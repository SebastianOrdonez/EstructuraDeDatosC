using System;

public class ListaEnlazada
{
    private Nodo cabeza = null;

    public void Insertar(int dato)
    {
        Nodo nuevo = new Nodo(dato);

        if (cabeza == null)
            cabeza = nuevo;
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
                actual = actual.Siguiente;

            actual.Siguiente = nuevo;
        }
    }

    public void Mostrar()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }

    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = cabeza;
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }

    public void Invertir()
    {
        Nodo anterior = null;
        Nodo actual = cabeza;
        Nodo siguiente;

        while (actual != null)
        {
            siguiente = actual.Siguiente;
            actual.Siguiente = anterior;
            anterior = actual;
            actual = siguiente;
        }
        cabeza = anterior;
    }
}
