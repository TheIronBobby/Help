using System;

namespace _18.TrailingZeroesInN_
{
    class TrailingZeros
    {
        static void Main()
        {
            Console.Write("Enter number N=");
            int numberN = int.Parse(Console.ReadLine());
            int k = 0;
            int result = 0;
            while (Math.Pow(5,k)<numberN)
            {
                k++;
                result += numberN / (int)(Math.Pow(5, k)); 
            }
            Console.WriteLine(result);
        }
    }
}
