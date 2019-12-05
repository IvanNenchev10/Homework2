using System;

namespace Задача3
{
    class Program
    {
        static void Main()
        {
            string name=" ", gender, colour;
            int age;
            double sum;
            char ch;
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter gender:");
            gender = Console.ReadLine();
            Console.WriteLine("Enter colour of the eyes");
            colour = Console.ReadLine();
            Console.WriteLine("Enter age:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sum:");
            sum = double.Parse(Console.ReadLine());
            ch = name[0];
            Console.WriteLine("{0}", name);
            Console.WriteLine("{0}", age);
            Console.WriteLine("{0}", gender);
            Console.WriteLine("{0}", sum);
            Console.WriteLine("{0}", colour);
            Console.WriteLine("First index of name is:{0}", ch);
        }
    }
}
