using System;
using System.Globalization;
using System.Threading;


namespace _02.GravityOnTheMoon
{
    class Moon
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.Write("Enter your weight on Earth ");
            double wheight = double.Parse(Console.ReadLine());
            double wheightMoon = wheight * 0.17;
            Console.WriteLine("Your weight on the Moon is {0}kg",wheightMoon);
        }
    }
}
