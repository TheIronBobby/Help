using System;


namespace _11.BitwiseExtractBitNumber3
{
    class BitNumb3
    {
        static void Main()
        {
            Console.WriteLine("Enter number!");
            int numb = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(numb, 2).PadLeft(16, '0'));
            int mask = 1;
            int nRight = numb >> 3;
            int bit = nRight & mask;
            Console.WriteLine("The #3 bit is {0}",bit);
        }
    }
}
