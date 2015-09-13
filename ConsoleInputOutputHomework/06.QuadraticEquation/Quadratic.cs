using System;
using System.Globalization;
using System.Threading;

namespace _06.QuadraticEquation
{
    class Quadratic
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            double a;
            do
            {
                Console.Write("Enter the first coefficient of the quadratic equation a=");
                a = double.Parse(Console.ReadLine());
            }
            while (a == 0);
            Console.Write("Enter the second coefficient of the quadratic equation b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the third coefficient of the quadratic equation c=");
            double c = double.Parse(Console.ReadLine());
            double discriminant = Math.Pow(b, 2) - 4*a*c;
            if (discriminant > 0)
            {
                double x1 = ((0 - b) + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = ((0 - b) - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("The roots of the quadratic equation is x1={0} and x2={1}",x1,x2);
            }
            if (discriminant == 0)
            {
                double x1 = (0 - b) / (2 * a);
                Console.WriteLine("The root of the quadratic equation is x1=x2={0}", x1);
            }
            if (discriminant<0)
            {
                Console.WriteLine("The quadratic equation has no real roots");
            }
        }
    }
}
