using System;
using System.Globalization;
using System.Threading;


namespace _09.SumOfnNumbers
{
    class Numbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            double sum = 0;
            int n;
            do
            {
                Console.Write("n=");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("The Sum of your numbers is {0}",sum);
        }
    }
}
