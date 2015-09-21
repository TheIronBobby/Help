using System;
using System.Globalization;
using System.Threading;


namespace _09.TrapezoidsArea
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.Write("Enter the trapezoid's side a=");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("Enter the trapezoid's side b=");
            double sideB = double.Parse(Console.ReadLine());
            Console.Write("Enter the trapezoid's hight h=");
            double hight = double.Parse(Console.ReadLine());
            double area = ((sideA + sideB) / 2) * hight;
            Console.WriteLine("The area of the trapezoid is S={0}",area);
        }
    }
}
