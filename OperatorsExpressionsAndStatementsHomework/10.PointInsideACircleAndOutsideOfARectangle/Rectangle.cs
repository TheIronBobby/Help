using System;
using System.Globalization;
using System.Threading;


namespace _10.PointInsideACircleAndOutsideOfARectangle
{
    class Rectangle
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.Write("Enter a point's coordinate x=");
            double pointX = double.Parse(Console.ReadLine());
            Console.Write("Enter a point's coordinate y=");
            double pointY = double.Parse(Console.ReadLine());
            double circCenterX = 1;
            double circCenterY = 1;
            double radius = 1.5;
            double rectX = -1;
            double rectY = 1;
            double rectHeight = 2;
            double rectWidth = 6;
            bool result = Math.Pow((pointX - circCenterX), 2) + Math.Pow((pointY - circCenterY), 2) <= Math.Pow(radius, 2) &&
                pointX > rectX && pointX < rectX + rectWidth && pointY > rectY && pointY < rectY + rectHeight;
            Console.WriteLine(result);
        }
    }
}
