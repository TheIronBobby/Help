using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam26AprilMorningProblem1
{
    class BookProblem
    {
        static void Main()
        {
            int numbOfPages = int.Parse(Console.ReadLine());
            int campDays = int.Parse(Console.ReadLine());
            int pagesInNormal = int.Parse(Console.ReadLine());

            int years = 0;
            int months = 0;
            double readTime = 0;
            if (campDays < 30)
            {
                readTime = Math.Ceiling((double)numbOfPages / ((30 - campDays) * pagesInNormal));
                years = (int)readTime / 12;
                months = (int)readTime % 12;
                Console.WriteLine("{0} years {1} months",years,months);

            }
            else
            {
                Console.WriteLine("never");
            }
        }
    }
}
