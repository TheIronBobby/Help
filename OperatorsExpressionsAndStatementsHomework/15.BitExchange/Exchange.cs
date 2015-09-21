using System;

namespace _15.BitExchange
{
    class Exchange
    {
        static void Main()
        {
            Console.Write("Enter number n=");
            uint num = uint.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(num,2).PadLeft(32,'0'));
            uint numP, bit1, bit2, mask1, mask2;

            //swap bits 3,4,5 with bits 24,25,26
            for (int i = 0; i < 3; i++)
            {
                // get bit 3 (,4,5)
                numP = num >> (3 + i);
                string stNumP = Convert.ToString(numP, 2);
                bit1 = numP & 1;
                string stBit1 = Convert.ToString(bit1, 2);
                // get bit 24 (,25,26)
                numP = num >> (24 + i);
                stNumP = Convert.ToString(numP, 2);
                bit2 = numP & 1;
                string stBit2 = Convert.ToString(bit2, 2);
                // shift bit 3 (,4,5) to positon 24 (,25,26)
                bit1 = bit1 << (24 + i);
                stBit1 = Convert.ToString(bit1, 2);
                // shift bit 24 (,25,26) to position 3 (,4,5)
                bit2 = bit2 << (3 + i);
                stBit2 = Convert.ToString(bit2, 2);
                // set bit 3 (,4,5) to zero
                mask1 =(uint) 1 << (3 + i);
                string stMask = Convert.ToString(mask1,2);
                num = num & ~mask1;
                string stNum = Convert.ToString(num,2);
                // set bit 24 (,25,26) to zero
                mask2 =(uint) 1 << (24 + i);
                string stMask2 = Convert.ToString(mask2,2);
                num = num & ~mask2;
                stNum = Convert.ToString(num,2);
                // put bit 3 (,4,5) in bit 24 (,25,26)
                num = num | bit1;
                stNum = Convert.ToString(num,2);
                // put bit 24 (,25,26) in bit 3 (,4,5)
                num = num | bit2;
                stNum = Convert.ToString(num,2);
            }
            Console.WriteLine(num);
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32,'0'));
        }
    }
}
