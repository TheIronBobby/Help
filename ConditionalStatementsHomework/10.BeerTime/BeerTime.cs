using System;
using System.Globalization;

namespace _10.BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            Console.WriteLine("Enter time in format \"hh:mm tt\": ");
            DateTime time = DateTime.Parse("0:00 AM");
            try
            {
                time = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid time");
                return;
            }
            DateTime startBeerTime = DateTime.Parse("1:00 PM");
            DateTime endBeerTime = DateTime.Parse("1:00 PM").AddHours(14).AddMinutes(-1);
            if ((time.Hour < 12)) 
            {
                time = time.AddDays(1);
            }

            if ((time >= startBeerTime) && (time <= endBeerTime))
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
    }
}
