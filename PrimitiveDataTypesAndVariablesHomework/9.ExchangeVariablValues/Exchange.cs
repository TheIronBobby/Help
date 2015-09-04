using System;

namespace _9.ExchangeVariablValues
{
    class Exchange
    {
        static void Main()
        {  
            int a = 5;
            int b = 10;
            int c;

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            if (b > a)
            {
                c = b;
                b = a;
                a = c;
                Console.WriteLine("After the exchange:");
                Console.WriteLine("a = {0}", a);
                Console.WriteLine("b = {0}", b);
            }
            else
            {
                Console.WriteLine("a = {0}", a);
                Console.WriteLine("b = {0}", b);
            }
        }   
    }
}
