using System;
using System.Linq;

namespace Exam30AugustProblem4
{
    class Deadpool
    {
        static void Main()
        {
            double[] a = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] b = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] c = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] d = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double radius = double.Parse(Console.ReadLine());
            double step = double.Parse(Console.ReadLine());
            int count = 0;
            for (double x = 0; x <= radius; x+=step)
            {
                for (double y = 0; y <= radius; y+=step)
                {
                    if (x * x + y * y <= radius * radius)
                    {
                        if (x > a[0] && x < c[0] && y > a[1] && y < c[1])
                        {
                            count++;  
                        }
                    }
                }
                for (double y = -step; y >= -radius; y -= step)
                {
                    if (x * x + y * y <= radius * radius)
                    {
                        if (x > a[0] && x < c[0] && y > a[1] && y < c[1])
                        {
                            count++;
                        }
                    }
                }
            }
            for (double x = -step; x >= -radius; x -= step)
            {
                for (double y = 0; y <= radius; y += step)
                {
                    if (x * x + y * y <= radius * radius)
                    {
                        if (x > a[0] && x < c[0] && y > a[1] && y < c[1])
                        {
                            count++;
                        }
                    }
                }
                for (double y = -step; y >= -radius; y -= step)
                {
                    if (x * x + y * y <= radius * radius)
                    {
                        if (x > a[0] && x < c[0] && y > a[1] && y < c[1])
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
