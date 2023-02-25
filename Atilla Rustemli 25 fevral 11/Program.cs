namespace Atilla_Rustemli_25_fevral_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("1-ci 5 reqemli ededi qeyd edin: ");
            int a = int.Parse(Console.ReadLine());
            if (!(9999 < a && a < 100000))
            {
                goto l1;
            }
        l2:
            Console.Write("2-ci 5 reqemli ededi qeyd edin: ");
            int b = int.Parse(Console.ReadLine());
            if (!(9999 < b && b < 100000))
            {
                goto l2;
            }
        l3:
            Console.Write("3-ci 5 reqemli ededi qeyd edin: ");
            int c = int.Parse(Console.ReadLine());
            if (!(9999 < c && c < 100000))
            {
                goto l3;
            }
        l4:
            Console.Write("4-ci 5 reqemli ededi qeyd edin: ");
            int d = int.Parse(Console.ReadLine());
            if (!(9999 < d && d < 100000))
            {
                goto l4;
            }
            int x = a + c;
            int y = b + d;
            long  n = x * y;
            double k = n - (c * 3) / 100;
            Console.WriteLine($"1-ci ve 3-cu ededin cemi: {x}");
            Console.WriteLine($"2-ci ve 4-cu ededin cemi: {y}");
            Console.WriteLine($"Alinan ededlerin hasili: {n}");
            Console.WriteLine($"Hasil ile 3-cu ededin 3 faizinin ferqi: {k} ");
        }
    }
}
