using System;
using System.Globalization;
using System.Threading;

namespace _03.CirclePerimeterAndArea
{
    class Circle
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.Write("Enter the circle's radius: r=");
            double r = double.Parse(Console.ReadLine());
            double Perimeter = 2 * 3.141592654 * r;
            double Area = Math.Pow(r, 2) * 3.141592654;
            Console.WriteLine("The Perimeter P= "+"{0:0.00}",Perimeter);
            Console.WriteLine("The Area S= " + "{0:0.00}", Area);
        }
    }
}
