using System;
using System.Globalization;
using System.Threading;

namespace _07.SumOfFiveNumbers
{
    class FiveNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Enter five numbers separated by space:");
            string numbers = Console.ReadLine();
            string[] stringNumbers = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0 ;
            for (int i = 0; i < 5; i++)
            {
                double number = double.Parse(stringNumbers[i]);
                sum += number;
            }
            Console.WriteLine("The sum of the five numbers is s={0}",sum);
        }
    }
}
