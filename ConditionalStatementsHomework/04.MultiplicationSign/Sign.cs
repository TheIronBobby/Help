using System;

namespace _04.MultiplicationSign
{
    class Sign
    {
        static void Main()
        {
            Console.Write("Enter number a=");
            double numberA = double.Parse(Console.ReadLine());
            Console.Write("Enter number b=");
            double numberB = double.Parse(Console.ReadLine());
            Console.Write("Enter number c=");
            double numberC = double.Parse(Console.ReadLine());
            int counter = 0;
            
            if (numberA < 0)
            {
                counter++;
            }
            if (numberB < 0)
            {
                counter++;
            }
            if (numberC < 0)
            {
                counter++;
            }
            int result = counter % 2;
            if (numberA == 0 || numberB == 0 || numberC == 0)
            {
                Console.WriteLine("0");
            }
            else if (result==0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
