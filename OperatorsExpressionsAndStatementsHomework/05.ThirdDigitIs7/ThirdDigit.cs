using System;


namespace _05.ThirdDigitIs7
{
    class ThirdDigit
    {
        static void Main()
        {
            Console.Write("Enter number n=");
            int numb = int.Parse(Console.ReadLine());
            bool result = ((numb /(int) Math.Pow(10, 2)) % 10) == 7;
            Console.WriteLine(result);
        }
    }
}
