namespace Atilla_Rustemli_25_fevral_15
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
            Console.Write("6 reqemli ededi qeyd edin: ");
            int c = int.Parse(Console.ReadLine());
            if (!(99999 < c && c < 1000000))
            {
                goto l3;
            }
        l4:
            Console.Write("1-ci 3 reqemli ededi qeyd edin: ");
            int d = int.Parse(Console.ReadLine());
            if (!(99 < d && d < 1000))
            {
                goto l4;
            }
        l5:
            Console.Write("2-ci 3 reqemli ededi qeyd edin: ");
            int e = int.Parse(Console.ReadLine());
            if (!(99 < e && e < 1000))
            {
                goto l5;
            }
        l6:
            Console.Write("1-ci 4 reqemli ededi qeyd edin: ");
            int f = int.Parse(Console.ReadLine());
            if (!(999 < f && f < 10000))
            {
                goto l6;
            }
        l7:
            Console.Write("2-ci 4 reqemli ededi qeyd edin: ");
            int g = int.Parse(Console.ReadLine());
            if (!(999 < g && g < 10000))
            {
                goto l7;
            }
            int n = d + e + f + g;
            double k = n * 10 + 7;
            double t = k + a + b;
            double q = t - ((d * e * 10) + 1);
            double r = q + c - n;
            double x = (((r * 18) / 100) * 3) / 1000;
            double y = x + a + b;
            Console.WriteLine($"3 ve 4 reqemli ededlerin cemi: {n}");
            Console.WriteLine($"Cemin sonuna 7 elave etdikde: {k}");
            Console.WriteLine($"Alinan ededin 5 reqemli ededlerle  cemi: {t}");
            Console.WriteLine($"Cemin 3 reqemli ededlerin hasilininin souna 1 elave edilmis hali ile ferqi: {q}");
            Console.WriteLine($"Alinan neticenin 6 reqemli ededle ceminin 3 ve 4 reqemli ededlerin cemi ile ferqi: {r}");
            Console.WriteLine($"Ferqin 18 faizini 3 faizinin 1 faizi: {x}");
            Console.WriteLine($"Alinan ededin 5 reqemli ededlerle cemi: {y}");

        }
    }
}