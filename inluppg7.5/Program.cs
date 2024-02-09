using System;
using System.Diagnostics.CodeAnalysis;

namespace inluppg7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv dina senaste månadslöner. Mata in 0 för att fortsätta");

            List<int> list = new List<int>();
            while (true)
            {
                string entry = Console.ReadLine();
                if (entry == "0")
                {
                    break;
                }
                else
                {
                    list.Add(int.Parse(entry));
                }
            }
            Console.WriteLine("Medelvärdet = " + Medelvarde(list));
            Console.WriteLine("Median = " + Median(list));

            static double Medelvarde(List<int> l)
            {
                double summa = 0;
                for (int i = 0; i < l.Count; i++)
                {
                    summa += l[i];
                }

                return summa/l.Count;
            }

            static double Median(List<int> l)
            {
                double median = 0;
                int length = l.Count;
                if (length%2 == 0)
                {
                    int summa = l[length/2] + l[length/2-1];
                    median = (double)summa/2;
                }
                else
                {
                    median = l[length/2];
                }

                return median;
            }
        }
    }
}