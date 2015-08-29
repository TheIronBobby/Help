using System;

namespace _08.SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            int number;
            double result;
            do
            {
                Console.WriteLine("Enter number!");
                number = Convert.ToInt32(Console.ReadLine());
            }
            while (number <= 0);
            result = Math.Sqrt(number);
            Console.WriteLine("The square root of YOUR number is {0}", result);  
        }
    }
}
