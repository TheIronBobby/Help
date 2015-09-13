using System;
using System.Globalization;
using System.Threading;


namespace _01.SumOfThreeNumbers
{
    class Sum
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.Write("Enter number a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter number c= ");
            double c = double.Parse(Console.ReadLine());

            double sum = a + b + c;
            Console.WriteLine("a+b+c= {0}",sum);
        }
    }
}
