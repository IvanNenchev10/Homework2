using System;

namespace Задача1
{
    class Program
    {
        static void Main()
        {
            uint a = 100;//value type
            int a1 = -100;// value type
            Console.WriteLine("{0},{1}", a, a1);
            ushort b = 50;//value type
            short b1 = -50;//value type
            Console.WriteLine("{0},{1}", b, b1);
            byte c = 1;//value type
            sbyte c1 = -1;//value type
            Console.WriteLine("{0},{1}", c, c1);
            ulong d = 100000000L;//value type
            long d1 = -1000000000L;//value type
            Console.WriteLine("{0},{1}", d, d1);
            float f = 5.6754893101f;
            Console.WriteLine("{0}", f);//value type
            double g = 5.6754893101d;
            Console.WriteLine("{0}", g);//value type
            decimal e = 5.6754893101m;
            Console.WriteLine("{0}", e);
            char ch = 'A';//value type
            Console.WriteLine("{0}", ch);
            bool result = true;//value type
            Console.WriteLine("{0}", result);
            string str = "Welcome";
            Console.WriteLine("{0}", str);//reference type
            object obj = 500;//reference type
            Console.WriteLine("{0}", obj);


        }
    }
}
