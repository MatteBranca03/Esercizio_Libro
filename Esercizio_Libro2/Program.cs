using System;
using System.Collections.Generic;

namespace Esercizio_Libro2
{
    class Esercizio2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quanti numeri vuoi inserire nel vettore");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                int n1 = r.Next(1, 1000000);
                list.Add(n1);
                list.Sort();
            }
            foreach (var n2 in list)
            Console.WriteLine($"{n2}");
            Console.ReadLine();
        }
    }
}
