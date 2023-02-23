namespace Atilla_Rustemli_25_fevral_13
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
        l5:
            Console.Write("5-ci 6 reqemli ededi qeyd edin: ");
            int e = int.Parse(Console.ReadLine());
            if (!(99999 < e && e < 1000000))
            {
                goto l5;
            }
        l6:
            Console.Write("6-cu 6 reqemli ededi qeyd edin: ");
            int f = int.Parse(Console.ReadLine());
            if (!(99999 < f && f < 1000000))
            {
                goto l6;
            }
            int n = a + b + c + d + e + f;
            int l = a * 1000;
            long k = l*1000 + c;
            double t = n - k;
            double q = t / 10;
            double r = q + e + f;
            double z = (r * 11) / 100;
            Console.WriteLine($"Butun ededlerin cemi: {n}");
            Console.WriteLine($"1-ci ve 3-cu ededlerin bitisdirilmis formasi: {k} " );
            Console.WriteLine($"1-ci ve 2-ci neticelerin ferqi: {t}");
            Console.WriteLine($"Ferqin 5-ci ve 6-ci ededlerle cemi: {r}");
            Console.WriteLine($"Cemin 11 faizi: {z}");


        }
    }
}