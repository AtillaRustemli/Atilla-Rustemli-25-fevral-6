namespace Atilla_Rustemli_25_fevral_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("1-ci 6 reqemli ededi qeyd edin: ");
            int n = int.Parse(Console.ReadLine());
            if (!(99999 < n && n < 1000000))
            {
                goto l1;
            }
        l2:
            Console.Write("2-ci 6 reqemli ededi qeyd edin: ");
            int k = int.Parse(Console.ReadLine());
            if (!(99999 < k && k < 1000000))
            {
                goto l2;
            }
        l3:
            Console.Write("3-ci 6 reqemli ededi qeyd edin: ");
            int t = int.Parse(Console.ReadLine());
            if (!(99999 < t && t < 1000000))
            {
                goto l3;

            }
            double a = n / 10;
            double b = k / 10;
            double c = t / 10;
            double d = a + b + c;
            double e = d / 10;
            Console.WriteLine($"1-ci ededin 10 faizi: {a}");
            Console.WriteLine($"2-ci ededin 10 faizi: {b}");
            Console.WriteLine($"3-ci ededin 10 faizi: {c}");
            Console.WriteLine($"Alinan ededlerin cemi: {d}");
            Console.WriteLine($"Ededlerin ceminin 10 faizi: {e}");
            
        }
    }
}