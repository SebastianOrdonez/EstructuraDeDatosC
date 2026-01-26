using System;
using System.Collections.Generic;

class BalanceoSimbolos
{
    static void Main()
    {
        string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";

        bool balanceada = EstaBalanceada(expresion);

        Console.WriteLine(balanceada ? "Fórmula balanceada." : "Fórmula NO balanceada.");
    }

    static bool EstaBalanceada(string texto)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in texto)
        {
            // Si es un símbolo de apertura, se apila
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            // Si es un símbolo de cierre, debe coincidir con el tope
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0) return false; // no hay con qué cerrar

                char tope = pila.Pop();

                // Verificamos correspondencia
                if (!EsPareja(tope, c)) return false;
            }
        }

        // Si quedó algo abierto sin cerrar, no está balanceada
        return pila.Count == 0;
    }

    static bool EsPareja(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '{' && cierre == '}') ||
               (apertura == '[' && cierre == ']');
    }
}
