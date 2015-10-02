using System;

namespace _02.NumbersNotDivisibleBy3And7
{
    class NumbersNotDivisibleBy3And7
    {
        static void Main()
        {
            Console.Write("Enter a positive number n=");
            int number;
            do
            {
                number = int.Parse(Console.ReadLine());
            } while (number < 1);

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
