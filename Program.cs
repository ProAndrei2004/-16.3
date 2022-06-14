using System;
using System.Collections.Generic;
using System.Linq;

namespace Практическая_16._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] m = new double[10] { 1.1, 2.1, 4.1, 1.1, 5.1, 5.1, 3.1, 3.1, 1.1, 1.1 };
            Console.WriteLine("исходный массив");
            Console.WriteLine();
            for (int i = 0; i < m.Length; i++)           
                Console.Write(m[i] + " ");           
            List<double> d = new List<double>();
            List<int> c1 = new List<int>();
            for (int i = 0; i < m.Length; i++)
            {
                int c = 1;
                c1.Clear();
                c1.Add(1);
                for (int j = 0; j < m.Length; j++)
                {
                    if (i != j)
                    {
                        if (m[i] == m[j])
                        {
                            c++;
                            c1.Add(1);
                        }
                    }
                }
                d.Add(c1.Sum());
            }
            Console.WriteLine("!");
            Console.WriteLine(d[7]);
            for (int i = 0; i < m.Length; i++)
            {
                Console.Write($"{i + 1}) {m[i]} == {d[i]}");
                Console.WriteLine();
            }
            double[] fin = new double[m.Length];
            Console.WriteLine("финальный массив");
            Console.WriteLine();
            for (int i = 0; i < fin.Length; i++)
            {
                fin[i] = m[i] * d[i];
                Console.Write(fin[i] + " ");
            }
        }
    }
}
