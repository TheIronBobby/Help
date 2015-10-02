using System;


namespace _05.Calculate
{
    class Calculate1
    {
        static void Main()
        {
            double sum = 0;
            ulong factorial = 1;
            Console.Write("Enter the coeficient n=");
            int coefN = int.Parse(Console.ReadLine());
            Console.Write("Enter the coeficient x=");
            int coefX = int.Parse(Console.ReadLine());
            for (uint i = 1; i <= coefN; i++)
            {
                factorial *= i;
                sum += factorial / (Math.Pow(coefX, i));
            }
            Console.WriteLine("{0:0.00000}",sum+1);
        }
    }
}
