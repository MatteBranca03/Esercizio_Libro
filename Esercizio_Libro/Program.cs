using System;
using System.Collections.Generic;

namespace Esercizio_Libro
{
    class Esercizio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci i numeri da inserire nel vettore");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(n);
            List<int> doppioni = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("inserisci un numero");
                int n1 = int.Parse(Console.ReadLine());
                if (list.Contains(n1))
                {
                    doppioni.Add(n1);
                }
                list.Add(n1);
            }
            for (int i = 0; i < doppioni.Count; i++)
            {
                Console.WriteLine($"il numero {doppioni[i]} è doppione.");
            }
            Console.ReadLine();
        }
    }
}