using System;

namespace _13.BinaryToDecimalNumber
{
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter binary number");
            string binary = Console.ReadLine();
            ulong decimalNum = 0;
            int count = binary.Length-1;
            for (int i = 0; i < binary.Length; i++)
            {
                
                char bit = binary[i];
                switch (bit)
                {
                    case '1':
                    decimalNum+=(ulong)Math.Pow(2,count);
                    break;
                    default:
                    break;
                }
                count--;
            }
            Console.WriteLine(decimalNum);
        }
    }
}
