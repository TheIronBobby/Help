using System;

namespace _10.FibunacciNumbers
{
    class Fibunacci
    {
        static void Main()
        {
            int n;
            do
            {
                Console.Write("Entere how many members from Fibonacci sequence\nn=");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 3);
            ulong firsNumb = 0;
            ulong secondNumb = 1;
            ulong fibSeq;
            for (int i = 0; i < n; i++)
            {
                fibSeq = firsNumb;
                firsNumb = secondNumb;
                secondNumb = fibSeq + firsNumb;
                Console.Write("{0} ",fibSeq);
            }
        }
    }
}
