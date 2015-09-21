using System;
using System.Globalization;
using System.Threading;

namespace _04.Rectangle
{
    class PerimeterArea
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.Write("Enter the rectangle's hight ");
            double hight = double.Parse(Console.ReadLine());
            Console.Write("Enter the rectangle's width ");
            double width = double.Parse(Console.ReadLine());
            double perimeter = (2 * hight) + (2 * width);
            double area = hight * width;
            Console.WriteLine("The perimeter and the area of the rectangle is P={0} S={1}",perimeter,area);
        }
    }
}
