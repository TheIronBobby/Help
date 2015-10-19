using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam29MarchEveningProblem1
{
    class CurencyCheck
    {
        static void Main()
        {
            decimal rubles = decimal.Parse(Console.ReadLine())/100m * 3.5m;
            decimal dollars = decimal.Parse(Console.ReadLine()) * 1.5m;
            decimal euro = decimal.Parse(Console.ReadLine()) * 1.95m;
            decimal bgDeal = decimal.Parse(Console.ReadLine()) / 2m;
            decimal bgNormal = decimal.Parse(Console.ReadLine());

            decimal bestDeal = rubles;
            if (dollars < bestDeal)
            {
                bestDeal = dollars;
            }
            if (euro < bestDeal)
            {
                bestDeal = euro;
            }
            if (bgDeal < bestDeal)
            {
                bestDeal = bgDeal;
            }
            if (bgNormal < bestDeal)
            {
                bestDeal = bgNormal;
            }
            Console.WriteLine("{0:F2}",bestDeal);
        }
    }
}
