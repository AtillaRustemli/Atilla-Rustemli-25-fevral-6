namespace Rustemli_Atilla_25_fevral_13
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
            double x = a / 20;
            double y = b / 20;
            double k = c / 20;
            double t = x * y * k;
            double n = (d * 3) / 100;
            double q = (e * 3) / 100;
            double f = n + q;
            double r = (t + f) / 10;
            Console.WriteLine($"5 reqemli ededlerin 5 faizinin hasil: {t}");
            Console.WriteLine($"3 reqemli ededlerin  3 faizinin cemi: {f}");
            Console.WriteLine($"Alinan neticelerin  ceminin 10 faizi: {r}");







        }
    }
}