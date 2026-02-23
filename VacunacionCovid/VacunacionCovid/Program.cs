using System;
using System.Collections.Generic;
using System.Linq;

namespace VacunacionCovid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Universo: 500 ciudadanos
            HashSet<string> ciudadanos = new HashSet<string>();

            for (int i = 1; i <= 500; i++)
            {
                ciudadanos.Add($"Ciudadano {i}");
            }

            // Conjunto vacunados Pfizer
            HashSet<string> pfizer = new HashSet<string>();

            for (int i = 1; i <= 75; i++)
            {
                pfizer.Add($"Ciudadano {i}");
            }

            // Conjunto vacunados AstraZeneca
            HashSet<string> astraZeneca = new HashSet<string>();

            for (int i = 51; i <= 125; i++)
            {
                astraZeneca.Add($"Ciudadano {i}");
            }

            // Unión (vacunados totales)
            HashSet<string> vacunados = new HashSet<string>(pfizer);
            vacunados.UnionWith(astraZeneca);

            // No vacunados
            HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
            noVacunados.ExceptWith(vacunados);

            // Ambas dosis (intersección)
            HashSet<string> ambasDosis = new HashSet<string>(pfizer);
            ambasDosis.IntersectWith(astraZeneca);

            // Solo Pfizer
            HashSet<string> soloPfizer = new HashSet<string>(pfizer);
            soloPfizer.ExceptWith(astraZeneca);

            // Solo AstraZeneca
            HashSet<string> soloAstraZeneca = new HashSet<string>(astraZeneca);
            soloAstraZeneca.ExceptWith(pfizer);

            // Mostrar resultados
            Console.WriteLine("===== RESULTADOS =====\n");

            Console.WriteLine($"Total ciudadanos: {ciudadanos.Count}");
            Console.WriteLine($"Vacunados Pfizer: {pfizer.Count}");
            Console.WriteLine($"Vacunados AstraZeneca: {astraZeneca.Count}");
            Console.WriteLine($"No vacunados: {noVacunados.Count}");
            Console.WriteLine($"Ambas dosis: {ambasDosis.Count}");
            Console.WriteLine($"Solo Pfizer: {soloPfizer.Count}");
            Console.WriteLine($"Solo AstraZeneca: {soloAstraZeneca.Count}");

            Console.ReadKey();
        }
    }
}