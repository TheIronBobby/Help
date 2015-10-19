using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exam26AprilEveningProblem2
{
    class PetarsGame
    {
        static void Main()
        {
            ulong startNumber = ulong.Parse(Console.ReadLine());
            ulong endNumber = ulong.Parse(Console.ReadLine());
            string replasment = Console.ReadLine();
            BigInteger sum = 0;
            string sumString = "";
            string digitToReplace;
            for ( ulong i = startNumber; i < endNumber; i++)
            {
                if (i % 5 == 0)
                {
                    sum += i;
                }
                else
                {
                    sum += (i % 5);
                }
            }
            sumString = sum.ToString();
            if (sum % 2 == 0)
            {
                digitToReplace = sumString[0].ToString();
            }
            else
            {
                digitToReplace = sumString[sumString.Length - 1].ToString();
            }
            sumString = sumString.Replace(digitToReplace, replasment);
            Console.WriteLine(sumString);
        }
    }
}
