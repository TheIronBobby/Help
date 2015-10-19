using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam29MarchEveningProblem3
{
    class MagicWand
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int width = (3 * input) + 2;

            Console.WriteLine("{0}*{0}", new string('.', width / 2));
            int inerDots = 1;
            int outerDots = (width/2)-inerDots;
            for (int i = 0; i <= input/2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', inerDots));
                inerDots += 2;
                outerDots --;
            }
            Console.WriteLine("{0}{1}{0}", new string('*', input), new string('.', input + 2));
            outerDots = 1;
            inerDots = width - 4;
            for (int i = 0; i < input/2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', inerDots));
                outerDots++;
                inerDots -= 2;
            }
            inerDots = 0;
            outerDots-=2;
            for (int i = 0; i < input/2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}", new string('.', outerDots), new string('.', input/2)
                    ,new string('.',inerDots),new string('.',input));
                inerDots++;
                outerDots--;
            }
            Console.WriteLine("{0}{1}*{2}*{1}{0}", new string('*',(int)Math.Ceiling((input/2d))), new string('.', inerDots),new string('.',input));
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("{0}*{0}*{0}",new string('.',input));
            }
            Console.WriteLine("{0}*{1}*{0}", new string('.', input),new string ('*',input));
        }
    }
}
