using System;


namespace _09.PrintASequence
{
    class Sequence
    {
        static void Main()
        {
            for(int number=2; number<12; number++)
            {
                if(number%2==0)
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
