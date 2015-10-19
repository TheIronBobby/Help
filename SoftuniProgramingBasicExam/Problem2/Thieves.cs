using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Thieves
    {
        static void Main()
        {
            int escapes = int.Parse(Console.ReadLine());
            int numbOfThieves = 0;
            int numbOfBeer = 0;
            long escaped = 0;
            long slaped = 0;
            long countBeers = 0;
            long packs = 0;
            
            for (int i = 0; i < escapes; i++)
            {
                numbOfThieves = int.Parse(Console.ReadLine());
                numbOfBeer = int.Parse(Console.ReadLine());
                
                if (numbOfThieves <= 5)
                {
                    slaped += numbOfThieves;
                    escaped += 0;
                }
                else
                {
                    slaped += 5;
                    escaped += numbOfThieves - 5;
                }
                countBeers += numbOfBeer;   
            }
            if (countBeers >= 6)
            {
                packs = countBeers / 6;
                countBeers %= 6;
            }
            else
            {
                packs = 0;
            }
            Console.WriteLine("{0} thieves slapped.",slaped);
            Console.WriteLine("{0} thieves escaped.",escaped);
            Console.WriteLine("{0} packs, {1} bottles.",packs,countBeers);
        }
    }
}
