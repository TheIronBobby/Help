using System;
using System.Numerics;

namespace _06.Calculate
{
    class Calculate2
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
            } while (coefK <1 || coefK > coefN || coefN > 100);
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            for (int i = 1; i <= coefN; i++)
            {
                factorialN *= i;
                if (i<=coefK)
                {
                    factorialK *= i;
                }
            }
            BigInteger result = factorialN / factorialK;
            Console.WriteLine("N!/K! = {0}",result);
        }
    }
}
