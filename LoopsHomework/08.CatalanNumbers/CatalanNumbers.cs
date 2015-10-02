using System;
using System.Numerics;

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            int number;
            do
            {
                Console.WriteLine("Enter N so that (1 < n < 100):");
                number = int.Parse(Console.ReadLine());
            } while (number<1||number>100);
            BigInteger factMult2 = 1;
            BigInteger factNPlus1 = 1;
            BigInteger factNumb = 1;
            for (int i = 1; i <= number*2; i++)
            {
                factMult2 *= i;
                if ((number + 1) >= i)
                {
                    factNPlus1 *= i;
                }
                if (number >= i)
                {
                    factNumb *= i; 
                }
            }
            BigInteger result = factMult2 / (factNPlus1 * factNumb);
            Console.WriteLine("Catalan(n) = {0}",result);
        }
    }
}
