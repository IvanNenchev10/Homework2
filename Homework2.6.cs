using System;


namespace Задача6
{
    class Program
    {
        static void Main()
        {
            string A, B, C;
            Console.WriteLine("Enter first string:");
            A = Console.ReadLine();
            Console.WriteLine("Enter second string:");
            B = Console.ReadLine();
            C = A + " " + B;
            Console.WriteLine("String after concatenation is:{0}", C);
        }
    }
}
