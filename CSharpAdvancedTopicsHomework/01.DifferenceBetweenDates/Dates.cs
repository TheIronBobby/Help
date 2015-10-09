using System;


namespace _01.DifferenceBetweenDates
{
    class Dates
    {
        static void Main()
        {
            Console.Write("Enter first date (dd.mm.yyyy):");
            string date1 = Console.ReadLine();
            DateTime firstDate = DateTime.Parse(date1);
            Console.Write("Enter second date(dd.mm.yyyy):");
            string date2 = Console.ReadLine();
            DateTime secondDate = DateTime.Parse(date2);
            TimeSpan differens = secondDate - firstDate;
            double result = differens.TotalDays;
            Console.WriteLine(result);
            
        }
    }
}
