using System;
namespace Задача10
{
    class Program
    {
        static void Main()
        {
            int number, sum = 0, counter = 0;
            while(counter<4)
            {
                Console.WriteLine("Enter number:");
                number = int.Parse(Console.ReadLine());
                sum = sum + number;
                counter++;
            }
            Console.WriteLine("Sum={0}", sum);
        }
    }
}
