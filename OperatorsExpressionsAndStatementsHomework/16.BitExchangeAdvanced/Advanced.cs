using System;


namespace _16.BitExchangeAdvanced
{
    class Advanced
    {
        static void Main()
        {
            Console.Write("Enter number n=");
            uint num = uint.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
            Console.Write("Enter starting bit position p=");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter the last bit position q=");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Enter the amount of bits k=");
            int k = int.Parse(Console.ReadLine());
            uint numP, bit1, bit2, mask1, mask2;
            if (p + k > q && q + k > p)
            {
                Console.WriteLine("Overlaping");
            }
            if (p < 0 || q < 0 || p > 32 || q > 32 || p + k > 32 || q + k > 32)
            {
                Console.WriteLine("Out of range!");
            }
            if (p + k < q || q + k < p || p > 0 || q > 0 || p < 32 || q < 32 || p + k < 32 || q + k < 32)
            {
                for (int i = 0; i < k; i++)
                {
                    numP = num >> (p + i);
                    bit1 = numP & 1;
                    numP = num >> (q + i);
                    bit2 = numP & 1;
                    bit1 = bit1 << (q + i);
                    bit2 = bit2 << (p + i);
                    mask1 = (uint)1 << (p + i);
                    num = num & ~mask1;
                    mask2 = (uint)1 << (q + i);
                    num = num & ~mask2;
                    num = num | bit1;
                    num = num | bit2;
                }
                Console.WriteLine(num);
                Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
            }
        }
    }
}
