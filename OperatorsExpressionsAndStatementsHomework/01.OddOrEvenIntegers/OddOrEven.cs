using System;

namespace _01.OddOrEvenIntegers
{
    class OddOrEven
    {
        static void Main()
        {
            Console.Write("Enter a number ");
            int a = int.Parse(Console.ReadLine());
            if (a%2==0)
            {
                Console.WriteLine("Your number is Even");

            }
            else
            {
                Console.WriteLine("Your number is Odd");
            }
        }
    }
}
