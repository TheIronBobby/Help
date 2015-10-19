using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam26AprilMorningProblem3
{
    class KingOfThieves
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char type = Console.ReadLine()[0];
            int numbOfChar = 1;
            int dashes = size/2;
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("{0}{1}{0}",new string('-',dashes),new string(type,numbOfChar));
                if (i < size / 2)
                {
                    numbOfChar += 2;
                    dashes--;
                }
                else
                {
                    numbOfChar -= 2;
                    dashes++;
                }
            }
        }
    }
}
