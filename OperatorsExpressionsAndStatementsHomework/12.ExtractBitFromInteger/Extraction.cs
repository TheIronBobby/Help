using System;

namespace _12.ExtractBitFromInteger
{
    class Extraction
    {
        static void Main()
        {
            Console.Write("Enter number n=");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
            Console.Write("Enter which bit you want to extract p=");
            int bitNumb = int.Parse(Console.ReadLine());
            int numbRightP = number >> bitNumb;
            int mask = 1;
            int result = numbRightP & mask;
            Console.WriteLine("The {0} bit is {1}",bitNumb,result);
        }
    }
}
