using System;
namespace Задача8
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("a={0}", a);
            Console.WriteLine("b={0}", b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a={0}", a);
            Console.WriteLine("b={0}", b);
        }
    }
}
