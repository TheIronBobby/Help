using System;


namespace _16.PrintLongSequence
{
    class LongSequence
    {
        static void Main()
        {
            for (int number = 2; number < 1002; number++)
            {
                if (number % 2 == 0)
                {
                    Console.Write(number);
                }
                else
                {
                    Console.Write("{0}{1}", '-', number);
                }
                Console.Write(",");
            }
        }
    }
}
