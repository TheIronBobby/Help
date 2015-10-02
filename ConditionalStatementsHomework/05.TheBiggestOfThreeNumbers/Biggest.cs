using System;


namespace _05.TheBiggestOfThreeNumbers
{
    class Biggest
    {
        static void Main()
        {
            Console.Write("Enter number a=");
            double numberA = double.Parse(Console.ReadLine());
            Console.Write("Enter number b=");
            double numberB = double.Parse(Console.ReadLine());
            Console.Write("Enter number c=");
            double numberC = double.Parse(Console.ReadLine());
            double biggestNumb = numberA;
            if (numberB > biggestNumb)
            {
                biggestNumb = numberB;
            }
            if (numberC > biggestNumb)
            {
                biggestNumb = numberC;
            }
            Console.WriteLine(biggestNumb);
        }
    }
}
