using System;

namespace _14.ModifyАBitАtGivenPosition
{
    class Modification
    {
        static void Main()
        {
            Console.Write("Enter number n=");
            int numb = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(numb,2).PadLeft(16,'0'));
            Console.Write("Enter the position of the bit you want to change p=");
            int posit = int.Parse(Console.ReadLine());
            int bit;
            do
            {
                Console.Write("Do you want \'0\' or \'1\' at this position? ");
                bit = int.Parse(Console.ReadLine());
            } while (bit > 1 || bit < 0);
            if (bit==0)
            {
               int result = numb & (~(1 << posit));
               Console.WriteLine("The new integer number is {0}", result);
               Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
            }
            if (bit==1)
            {
               int result = numb | (1 << posit);
               Console.WriteLine("The new integer number is {0}", result);
               Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
            }
        }
    }
}
