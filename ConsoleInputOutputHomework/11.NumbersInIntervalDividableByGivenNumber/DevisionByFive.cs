using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumbersInIntervalDividableByGivenNumber
{
    class DevisionByFive
    {
        static void Main()
        {
            Console.Write("Enter the starting number ");
            int startNumb = int.Parse(Console.ReadLine());
            Console.Write("Enter the ending number ");
            int endNumb = int.Parse(Console.ReadLine());
            int p=0;
            for (int i = startNumb; i <= endNumb; i++)
            {
                if (i%5==0)
                {
                    p++;
                }
            }
            Console.WriteLine("The amount of nubers devidebal by 5 is p={0}",p);
        }
    }
}
