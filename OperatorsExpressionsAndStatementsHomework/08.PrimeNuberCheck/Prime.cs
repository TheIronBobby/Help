using System;

namespace _08.PrimeNuberCheck
{
    class Prime
    {
        static void Main()
        {
            Console.WriteLine("Enter a number!");
            int number = int.Parse(Console.ReadLine());
            if (number <= 1)
            {
                Console.WriteLine(number + " is not a prime");
            }
            else
            {
                int sqrtNumber = (int)Math.Sqrt(number);
                for (int i = 2; i <= sqrtNumber; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine(number + " is not a prime");
                        return;
                    } 
                } 
                Console.WriteLine(number + " is prime");
            }
        }
    }
}
