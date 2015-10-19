using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam26AprilMorningProblem2
{
    class ChessboardGame
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int scoreBlack = 0;
            int scoreWhite = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                if (i >= n * n)
                {
                    break;
                }
                else if (i % 2 == 0)
                {
                    if (Char.IsLetter(input[i]) && Char.IsUpper(input[i]))
                    {
                        scoreWhite += input[i];
                    }
                    else if (!Char.IsLetterOrDigit(input[i]))
                    {
                        continue;
                    }
                    else
                    {
                        scoreBlack += input[i];
                    }
                }
                else
                {
                    if (Char.IsLetter(input[i]) && Char.IsUpper(input[i]))
                    {
                        scoreBlack += input[i];
                    }
                    else if (!Char.IsLetterOrDigit(input[i]))
                    {
                        continue;
                    }
                    else
                    {
                        scoreWhite += input[i];
                    }
                }
            }
            if (scoreBlack > scoreWhite)
            {
                Console.WriteLine("The winner is: black team");
                Console.WriteLine(scoreBlack - scoreWhite);
            }
            else if (scoreWhite == scoreBlack)
            {
                Console.WriteLine("Equal result: {0}",scoreWhite);
            }
            else
            {
                Console.WriteLine("The winner is: white team");
                Console.WriteLine(scoreWhite - scoreBlack);
            }
        }
    }
}
