using System;

public class ArbolBST
{
    public Nodo Raiz;

    // Insertar
    public Nodo Insertar(Nodo raiz, int valor)
    {
        if (raiz == null)
            return new Nodo(valor);

        if (valor < raiz.Valor)
            raiz.Izquierdo = Insertar(raiz.Izquierdo, valor);
        else if (valor > raiz.Valor)
            raiz.Derecho = Insertar(raiz.Derecho, valor);

        return raiz;
    }

    // Buscar
    public bool Buscar(Nodo raiz, int valor)
    {
        if (raiz == null)
            return false;

        if (valor == raiz.Valor)
            return true;

        if (valor < raiz.Valor)
            return Buscar(raiz.Izquierdo, valor);
        else
            return Buscar(raiz.Derecho, valor);
    }

    // Encontrar mínimo
    public Nodo Minimo(Nodo raiz)
    {
        while (raiz.Izquierdo != null)
            raiz = raiz.Izquierdo;
        return raiz;
    }

    // Eliminar
    public Nodo Eliminar(Nodo raiz, int valor)
    {
        if (raiz == null)
            return null;

        if (valor < raiz.Valor)
            raiz.Izquierdo = Eliminar(raiz.Izquierdo, valor);
        else if (valor > raiz.Valor)
            raiz.Derecho = Eliminar(raiz.Derecho, valor);
        else
        {
            // Caso 1: sin hijos
            if (raiz.Izquierdo == null && raiz.Derecho == null)
                return null;

            // Caso 2: un hijo
            if (raiz.Izquierdo == null)
                return raiz.Derecho;
            if (raiz.Derecho == null)
                return raiz.Izquierdo;

            // Caso 3: dos hijos
            Nodo sucesor = Minimo(raiz.Derecho);
            raiz.Valor = sucesor.Valor;
            raiz.Derecho = Eliminar(raiz.Derecho, sucesor.Valor);
        }

        return raiz;
    }

    // Recorridos
    public void Inorden(Nodo raiz)
    {
        if (raiz != null)
        {
            Inorden(raiz.Izquierdo);
            Console.Write(raiz.Valor + " ");
            Inorden(raiz.Derecho);
        }
    }

    public void Preorden(Nodo raiz)
    {
        if (raiz != null)
        {
            Console.Write(raiz.Valor + " ");
            Preorden(raiz.Izquierdo);
            Preorden(raiz.Derecho);
        }
    }

    public void Postorden(Nodo raiz)
    {
        if (raiz != null)
        {
            Postorden(raiz.Izquierdo);
            Postorden(raiz.Derecho);
            Console.Write(raiz.Valor + " ");
        }
    }

    // Máximo
    public Nodo Maximo(Nodo raiz)
    {
        while (raiz.Derecho != null)
            raiz = raiz.Derecho;
        return raiz;
    }

    // Altura
    public int Altura(Nodo raiz)
    {
        if (raiz == null)
            return -1;

        int izq = Altura(raiz.Izquierdo);
        int der = Altura(raiz.Derecho);

        return Math.Max(izq, der) + 1;
    }

    // Limpiar árbol
    public void Limpiar()
    {
        Raiz = null;
    }
}