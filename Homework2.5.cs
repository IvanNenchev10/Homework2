using System;
namespace Задача5
{
    class Program
    {
        static void Main()
        {
            int a, h;
            double product = 0.0;
            Console.WriteLine("Enter a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter h:");
            h = int.Parse(Console.ReadLine());
            product = (double)a * (double)h;
            product = product / 2;
            Console.WriteLine("Result={0}", product);
        }
    }
}
