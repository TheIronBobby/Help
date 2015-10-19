using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam26AprilEveningProblem3
{
    class Sun
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = n * 3;

            Console.WriteLine("{0}*{0}",new string('.',width/2));
            int inerDots = (width / 2) - 2;
            int outerDots = 1;
            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}",new string('.',outerDots),new string('.',inerDots));
                inerDots--;
                outerDots++;
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
            }
            Console.WriteLine("{0}",new string('*',width));
            for (int i = 0; i < n/2 ; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
            }
            for (int i = 0; i < n-1; i++)
            {
                inerDots++;
                outerDots--;
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', outerDots), new string('.', inerDots));
            }
            Console.WriteLine("{0}*{0}", new string('.', width / 2));
        }
    }
}
