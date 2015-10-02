using System;
using System.Globalization;
using System.Threading;

namespace _01.ExchangeIfGreater
{
    class Exchange
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.Write("Enter number a=");
            double numberA = double.Parse(Console.ReadLine());
            Console.Write("Enter number b=");
            double numberB = double.Parse(Console.ReadLine());
            if (numberA > numberB)
            {
                Console.WriteLine("{0} {1}", numberB, numberA);
            }
            else
            {
                Console.WriteLine("{0} {1}", numberA,numberB);
            }
        }
    }
}
