using System;
using System.Numerics;


namespace _07.Calculate
{
    class Combinatorics
    {
        static void Main()
        {
            int coefN = 0;
            int coefK = 0;
            do
            {
                Console.WriteLine("Enter N and K so that 1 < k < n < 100:");
                coefN = int.Parse(Console.ReadLine());
                coefK = int.Parse(Console.ReadLine());
            } while (coefK < 1 || coefK > coefN || coefN > 100);
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            BigInteger factNMinK = 1;
            
            for (int i = 1; i <= coefN; i++)
            {
                factorialN *= i;
                if (coefK >= i)
                {
                    factorialK *= i;
                }
                if ((coefN - coefK) >= i)
                {
                    factNMinK *= i; 
                }
            }
            BigInteger result = factorialN / (factorialK * factNMinK);
            Console.WriteLine("There are {0} possible combinations!",result);
        }
    }
}
