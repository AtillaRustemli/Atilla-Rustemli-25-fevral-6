namespace Atilla_Rustemli_25_fevral_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("1-ci 6 reqemli ededi qeyd edin: ");
            int a = int.Parse(Console.ReadLine());
            if (!(99999 < a && a < 1000000))
            {
                goto l1;
            }
        l2:
            Console.Write("2-ci 6 reqemli ededi qeyd edin: ");
            int b = int.Parse(Console.ReadLine());
            if (!(99999 < b && b < 1000000))
            {
                goto l2;
            }
        l3:
            Console.Write("3-ci 6 reqemli ededi qeyd edin: ");
            int c = int.Parse(Console.ReadLine());
            if (!(99999 < c && c < 1000000))
            {
                goto l3;
            }
        l4:
            Console.Write("4-ci 6 reqemli ededi qeyd edin: ");
            int d = int.Parse(Console.ReadLine());
            if (!(99999 < d && d < 1000000))
            {
                goto l4;
            }
            double x = a / 10 + b / 10 + c / 10 + d / 10;
            double y = (a * 15) / 100 + (b * 0) / 100 + (c * 15) / 100 + (d * 15) / 100;
            double n = x * y;
            double k = n / 10;
            double t = (k * 11) / 100;
            Console.WriteLine($"Ededlerin 10 faizinin cemi: {x}");
            Console.WriteLine($"Ededlerin 15 faizinin cemi: {y}");
            Console.WriteLine($"Ededlerin 10 ve 15 faizinin hasili: {n}");
            Console.WriteLine($"Hasilin 10 faizi: {k}");
            Console.WriteLine($"Hasilin 10 faizinin 11 faizi: {t}");





        }
    }
}