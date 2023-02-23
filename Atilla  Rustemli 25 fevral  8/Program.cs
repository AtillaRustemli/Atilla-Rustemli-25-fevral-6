


namespace Atilla__Rustemli_25_fevral__8
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("4 reqemli ededi qeyd edin: ");
            int n = int.Parse(Console.ReadLine());
            if (!(999 < n && n < 10000))
            {
                goto l1;
            }
        l2:
            Console.Write("7 reqemli ededi qeyd edin: ");
            int k = int.Parse(Console.ReadLine());
            if (!(999999 < k && k < 10000000))
            {
                goto l2;
            }
            double a = (n * 4) / 100;
            double b = (k * 9) / 100;
            double c = ((a + b) * 10) / 100;
            Console.WriteLine($"1-ci ededin 4 faizi: {a}");
            Console.WriteLine($"2-ci ededin 9 faizi: {b}");
            Console.WriteLine($"Alinan ededlerin ceminin 10 faizi: {c}");



        }
    }
}