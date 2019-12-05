using System;
namespace Задача2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.1
            string result = "Hello" + " " + "World";
            Console.WriteLine("Result={0}", result);
            //2.2
            bool res = false;
            res = (result.Length == 10) ? true : false;
            if (res == true)
            {
                Console.WriteLine("Length is 10");
            }
            else
            {
                Console.WriteLine("Length is not 10");
            }
            //2.3
            int index = result.IndexOf("W");
            if (index != -1)
            {
                Console.WriteLine("First index of W is at position:{0}", index);
            }
            else
            {
                Console.WriteLine("W does not exist in the string");
            }
            //2.4
            string product = result.ToUpper();
            Console.WriteLine("{0}", product);
            //2.5
            Console.WriteLine("String={0}", result);
            //2.6
           string output = result.Replace("World", "Programming");
            Console.WriteLine("String={0}", output);
        }
    }
}
