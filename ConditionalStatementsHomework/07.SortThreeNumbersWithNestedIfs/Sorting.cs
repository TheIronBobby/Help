using System;

namespace _07.SortThreeNumbersWithNestedIfs
{
    class Sorting
    {
        static void Main()
        {
            Console.Write("Enter number a=");
            double numberA = double.Parse(Console.ReadLine());
            Console.Write("Enter number b=");
            double numberB = double.Parse(Console.ReadLine());
            Console.Write("Enter number c=");
            double numberC = double.Parse(Console.ReadLine());
            if (numberA == numberB && numberA == numberC)
            {
                Console.WriteLine("{0} {1} {2}", numberA, numberB, numberC);
            }
            if (numberA > numberB && numberA > numberC)
                if (numberB > numberC)
                {
                    Console.WriteLine("{0} {1} {2}", numberA, numberB, numberC);
                }
                else if (numberB < numberC)
                {
                    Console.WriteLine("{0} {1} {2}", numberA, numberC, numberB);
                }
                else if (numberB == numberC)
                {
                    Console.WriteLine("{0} {1} {2}", numberA, numberC, numberB);
                }
            if (numberB > numberA && numberB > numberC)
                if (numberA > numberC)
                {
                    Console.WriteLine("{0} {1} {2}", numberB, numberA, numberC);
                }
                else if (numberC > numberA)
                {
                    Console.WriteLine("{0} {1} {2}", numberB, numberC, numberA);
                }
                else if (numberC == numberA)
                {
                    Console.WriteLine("{0} {1} {2}", numberB, numberC, numberA);
                }
            if (numberC > numberA && numberC > numberB)
                if (numberA > numberB)
                {
                    Console.WriteLine("{0} {1} {2}", numberC, numberA, numberB);
                }
                else if (numberB > numberA)
                {
                    Console.WriteLine("{0} {1} {2}", numberC, numberB, numberA);
                }
                else if (numberB == numberA)
                {
                    Console.WriteLine("{0} {1} {2}", numberC, numberB, numberA);
                }
        }
    }
}
