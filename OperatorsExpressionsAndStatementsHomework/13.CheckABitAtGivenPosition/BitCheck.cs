using System;

namespace _13.CheckABitAtGivenPosition
{
    class BitCheck
    {
        static void Main()
        {
            Console.Write("Enter number n=");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number,2).PadLeft(16,'0'));
            Console.Write("Enter bit position you want to check p=");
            int check = int.Parse(Console.ReadLine());
            int mask = 1;
            int numbRight = number >> check; 
            int result = numbRight & mask;
            bool isOne = result == 1;
            Console.WriteLine("Is bit number {0} = 1? \n{1}",check,isOne);
        }
    }
}
