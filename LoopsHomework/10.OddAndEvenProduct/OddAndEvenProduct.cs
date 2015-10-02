using System;

namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            Console.WriteLine("Enter integers with a space between them:");
            string[] input = Console.ReadLine().Split();
            int[] num = Array.ConvertAll(input, int.Parse);
            int sumOdd = 1;
            int sumEven = 1;
            for (int i = 0; i < num.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sumOdd *= num[i];
                }
                else
                {
                    sumEven *= num[i];
                }
            }
            if (sumEven == sumOdd)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product={0}", sumOdd);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product={0}", sumOdd);
                Console.WriteLine("even_product={0}", sumEven);
            }
        }
    }
}
