using System;
namespace Задача12
{
    class Program
    {
        static void Main()
        {
            //12.1
            string text, result;
            Console.WriteLine("Enter text:");
            text = Console.ReadLine();
            result = text.Substring(0, 3);
            Console.WriteLine("First three letters of the string are:{0}", result);
            //12.2
            int index = text.IndexOf("o");
            if(index!=-1)
            {
                Console.WriteLine("o is at position {0}", index);
            }
            else
            {
                Console.WriteLine("Letter o does not appear in the string");
            }
            //12.3
            int number;
            double square;
            Console.WriteLine("Enter number:");
            number = int.Parse(Console.ReadLine());
            square = Math.Sqrt(number);
            Console.WriteLine("Square root of number {0} is:{1}", number, square);
            //12.4
            string a, b;
            int num1, num2, sum;
            Console.WriteLine("Enter first string:");
            a = Console.ReadLine();
            Console.WriteLine("Enter second string:");
            b = Console.ReadLine();
            num1 = Convert.ToInt32(a);
            num2 = Convert.ToInt32(b);
            sum = num1 + num2;
            Console.WriteLine("Sum of {0} and {1} is:{2}", num1, num2, sum);

        }
    }
}
