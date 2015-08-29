using System;


namespace _06.PrintNumbers
{
    class PrintNumbers
    {
        static void Main()
        {
            for (int number = 1; number <= 9; number += 4)
            {
                string binary = Convert.ToString(number, 2);
                Console.WriteLine(binary);
            }
        }
    }
}
