using System;
using System.Globalization;
using System.Threading;

namespace _07.PointInACircle
{
    class Circle
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            int centerX = 0;
            int centerY = 0;
            int radius = 2;
            Console.Write("Enter coordinate of a point x=");
            double pointX = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinate of a point y=");
            double pointY = double.Parse(Console.ReadLine());
            bool result = Math.Pow((pointX - centerX), 2) + Math.Pow((pointY - centerY), 2) <= Math.Pow(radius, 2);
            Console.WriteLine(result);
        }
    }
}
