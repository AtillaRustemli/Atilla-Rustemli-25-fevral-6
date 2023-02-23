namespace Atilla_Rustemli_25_fevral_6
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
            double x = (n * 2) / 100;
            double y = x * x;
            Console.WriteLine($"Verilmish ededin 20 faizinin 10 faizi: {x}");
            Console.WriteLine($"Alinan ededin kvadrati: {y}");
        }
    }
}