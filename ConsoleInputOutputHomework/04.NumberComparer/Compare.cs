using System;
using System.Globalization;
using System.Threading;

namespace _04.NumberComparer
{
    class Compare
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.Write("Enter number a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number b=");
            double b = double.Parse(Console.ReadLine());
            double max = (a+b)/2+Math.Abs((a-b)/2);
            Console.WriteLine("The greater number is {0}",max);
        }
    }
}
