using System;

namespace _17.CalculateGCD
{
    class GCD
    {
        static void Main()
        {
            Console.Write("Enter the first number A=");
            int numbA = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number B=");
            int numbB = int.Parse(Console.ReadLine());
            int devisRes = 0;
            int remainder = 1;
            if (numbA > numbB)
            {
                while (remainder != 0)
                {
                    devisRes = numbA / numbB;
                    remainder = numbA % numbB;
                    numbA = numbB;
                    numbB = remainder;
                }
                Console.WriteLine(numbA);
            }
            else
	        {
                while (remainder != 0)
                {
                    devisRes = numbB/ numbA;
                    remainder = numbB % numbA;
                    numbB = numbA;
                    numbA = remainder;
                }
                Console.WriteLine(numbB);
	        }

        }
    }
}
