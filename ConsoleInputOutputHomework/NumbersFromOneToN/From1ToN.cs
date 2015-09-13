using System;

namespace _08.NumbersFromOneToN
{
    class From1ToN
    {
        static void Main()
        {
            Console.WriteLine("Enter the last number n=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
