using System;


namespace _01.NumbersFrom1ToN
{
    class NumbersFrom1ToN
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
                Console.Write(i + " ");
            }
        }
    }
}
