using System;
namespace Задача11
{
    class Program
    {
        static void Main()
        {
            int radius;
            double area, perimeter;
            Console.WriteLine("Enter radius of the circle:");
            radius = int.Parse(Console.ReadLine());
            area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Area of the circle is:{0}", Math.Round(area,2));
            perimeter = 2 * (Math.PI * radius);
            Console.WriteLine("Perimeter of the rectangle is:{0}", Math.Round(perimeter,2));

        }
        
    }
}
