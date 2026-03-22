using System;

class Program
{
    static void Main(string[] args)
    {
        ArbolBST arbol = new ArbolBST();
        int opcion, valor;

        do
        {
            Console.WriteLine("\n--- MENÚ BST ---");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Recorridos");
            Console.WriteLine("5. Minimo y Maximo");
            Console.WriteLine("6. Altura");
            Console.WriteLine("7. Limpiar árbol");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese valor: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Raiz = arbol.Insertar(arbol.Raiz, valor);
                    break;

                case 2:
                    Console.Write("Ingrese valor a buscar: ");
                    valor = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol.Buscar(arbol.Raiz, valor) ? "Encontrado" : "No encontrado");
                    break;

                case 3:
                    Console.Write("Ingrese valor a eliminar: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Raiz = arbol.Eliminar(arbol.Raiz, valor);
                    break;

                case 4:
                    Console.WriteLine("Inorden:");
                    arbol.Inorden(arbol.Raiz);
                    Console.WriteLine("\nPreorden:");
                    arbol.Preorden(arbol.Raiz);
                    Console.WriteLine("\nPostorden:");
                    arbol.Postorden(arbol.Raiz);
                    break;

                case 5:
                    if (arbol.Raiz != null)
                    {
                        Console.WriteLine("Minimo: " + arbol.Minimo(arbol.Raiz).Valor);
                        Console.WriteLine("Maximo: " + arbol.Maximo(arbol.Raiz).Valor);
                    }
                    else
                    {
                        Console.WriteLine("El árbol está vacío");
                    }
                    break;

                case 6:
                    Console.WriteLine("Altura: " + arbol.Altura(arbol.Raiz));
                    break;

                case 7:
                    arbol.Limpiar();
                    Console.WriteLine("Árbol eliminado");
                    break;
            }

        } while (opcion != 0);
    }
}