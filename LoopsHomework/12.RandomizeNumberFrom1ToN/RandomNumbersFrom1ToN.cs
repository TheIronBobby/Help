using System;


namespace _12.RandomizeNumberFrom1ToN
{
    class RandomNumbersFrom1ToN
    {
        static void Main()
        {
            Console.Write("Enter the amount of numbers n = ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            Random random = new Random();

            int randomNumber = random.Next(1, n + 1);
            numbers[0] = randomNumber;
            Console.Write("{0} ",numbers[0]);
            for (int i = 1; i < n; i++)
            {
                randomNumber = random.Next(1, n + 1);

                int count = 0;
                while (count <= i)
                {
                    if (numbers[count] == randomNumber)
                    {
                        randomNumber = random.Next(1, n + 1);
                        count = 0;
                    }
                    else
                    {
                        count++;
                    }
                }

                numbers[i] = randomNumber;
                Console.Write("{0} ",numbers[i]);
            }
            Console.WriteLine();
        }
    }
}
