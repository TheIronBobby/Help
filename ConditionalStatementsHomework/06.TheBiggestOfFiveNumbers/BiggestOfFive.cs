using System;


namespace _06.TheBiggestOfFiveNumbers
{
    class BiggestOfFive
    {
        static void Main()
        {
            Console.Write("Enter number a=");
            double numberA = double.Parse(Console.ReadLine());
            Console.Write("Enter number b=");
            double numberB = double.Parse(Console.ReadLine());
            Console.Write("Enter number c=");
            double numberC = double.Parse(Console.ReadLine());
            Console.Write("Enter number d=");
            double numberD = double.Parse(Console.ReadLine());
            Console.Write("Enter number e=");
            double numberE = double.Parse(Console.ReadLine());
            double biggestNumb = numberA;
            if (numberB > biggestNumb)
            {
                biggestNumb = numberB;
            }
            if (numberC > biggestNumb)
            {
                biggestNumb = numberC;
            }
            if (numberD > biggestNumb)
            {
                biggestNumb = numberD;
            }
            if (numberE > biggestNumb)
            {
                biggestNumb = numberE;
            }
            Console.WriteLine(biggestNumb);
        }
    }
}
