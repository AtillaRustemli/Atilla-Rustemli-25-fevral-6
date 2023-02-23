using System;

namespace Atilla_Rustemli_25_fevral_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("1-ci 4 reqemli ededi qeyd edin: ");
            int n = int.Parse(Console.ReadLine());
            if (!(999 < n && n < 10000))
            {
                goto l1;
            }
        l2:
            Console.Write("2-ci 4 reqemli ededi qeyd edin: ");
            int k = int.Parse(Console.ReadLine());
            if (!(999 < k && k < 10000))
            {
                goto l2;
            }
        l3:
            Console.Write("3-ci 4 reqemli ededi qeyd edin: ");
            int t = int.Parse(Console.ReadLine());
            if (!(999 < t && t < 10000))
            {
                goto l3;
            }
            double a = n / 100;
            double b = k / 50;
            double c = (t * 3) / 100;
            double d = a - b - c;
            double e = d + (t * 7) / 100;
            Console.WriteLine($"1-ci ededin 1 faizi: {a}");
            Console.WriteLine($"2-ci ededin 2 faizi: {b}");
            Console.WriteLine($"3-cu ededin 3 faizi: {c}");
            Console.WriteLine($"Alinan ededlerin ferqi: {d}");
            Console.WriteLine($"Ferqin 3-cu ededin 7 faizi il' cemi: {e}");

        }
    }
}