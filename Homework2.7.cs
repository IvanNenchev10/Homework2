using System;
namespace Задача7
{
    class Program
    {
        static void Main()
        {
            float height, width;
            decimal result = 0.0m;
            Console.WriteLine("Enter height of the triangle:");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter width of the triangle:");
            width = float.Parse(Console.ReadLine());
            result = (decimal)height * (decimal)width;
            Console.WriteLine("Area of the rectangle is:{0}", Math.Round(result, 2));
        }
    }
}
