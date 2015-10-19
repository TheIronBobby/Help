using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam12JulyProblem1
{
    class FourFactors
    {
        static void Main()
        {
            uint fieldGoals = uint.Parse(Console.ReadLine());
            uint fieldGoalsAttempts = uint.Parse(Console.ReadLine());
            uint point3Goal = uint.Parse(Console.ReadLine());
            uint turnovers = uint.Parse(Console.ReadLine());
            uint offensiveRebounds = uint.Parse(Console.ReadLine());
            uint opponentDefensiveRebounds = uint.Parse(Console.ReadLine());
            uint freeThrows = uint.Parse(Console.ReadLine());
            uint freeThrowsAttempts = uint.Parse(Console.ReadLine());

            double eFG = (fieldGoals + 0.5 * point3Goal) / fieldGoalsAttempts;
            double turnoverPercentage = turnovers / (fieldGoalsAttempts + 0.44 * freeThrowsAttempts + turnovers);
            double offensiveReboundingPercentage = (double)offensiveRebounds / (offensiveRebounds + opponentDefensiveRebounds);
            double freeThrowPercentage = (double)freeThrows / fieldGoalsAttempts;

            Console.WriteLine("eFG% {0:F3}",eFG);
            Console.WriteLine("TOV% {0:F3}",turnoverPercentage);
            Console.WriteLine("ORB% {0:F3}",offensiveReboundingPercentage);
            Console.WriteLine("FT% {0:F3}",freeThrowPercentage);
        }
    }
}
