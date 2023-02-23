namespace Atilla_Rustemli_25_fevral_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            l1:
            Console.Write("1-ci 5 reqemli ededi qeyd edin: ");
            int n = int.Parse(Console.ReadLine());
            if (!(9999 < n && n < 100000))
            {
                goto l1;
            }
            l2:
            Console.Write("2-ci 5 reqemli ededi qeyd edin: ");
            int k = int.Parse(Console.ReadLine());
            if (!(9999 < k && k < 100000))
            {
                goto l2;
            }
            int x = n + k;
            int y;
            if (99999 < x && x < 200000)
            {
                 y = 50000000 + (x * 10) + 5;
            }
            else
            {
                y = 5000000 + (x * 10) + 5;
            }
            double a = (y * 5) / 100;
            Console.WriteLine($"Ededlerin ceminin evveline ve sonuna 5 artirildiqda alinan netice: {y}");
            Console.WriteLine($"Alinan ededin 5 faizi: {a}");

        }
    }
}