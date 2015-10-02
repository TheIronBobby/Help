using System;

namespace _11.RandomNumbersInGivenRange
{
    class RandomNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter how many random numbers you want to be generated!");
            int numbers = int.Parse(Console.ReadLine());
            int max;
            int min;
            do
            {
                Console.WriteLine("Enter minimum number");
                min = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter maximum number");
                max = int.Parse(Console.ReadLine());
            } while (max < min);
            Random rnd = new Random();
            for (int i = 0; i < numbers; i++)
            {
                int randumNumber = rnd.Next(min, max + 1);
                Console.Write("{0} ",randumNumber);
            }
            Console.WriteLine();
        }
    }
}
