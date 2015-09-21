using System;


namespace _06.FourDigitNumber
{
    class FourDigit
    {
        static void Main()
        {
            int numb;
            do
            {
                Console.Write("Enter a four-digit number ");
                numb = int.Parse(Console.ReadLine());
            } while (numb < 999 || numb > 10000);
            int numbD = numb%10;
            int numbC = (numb / 10) % 10;
            int numbB = (numb / (int)Math.Pow(10, 2)) % 10;
            int numbA = (numb / (int)Math.Pow(10, 3)) % 10;
            Console.WriteLine(numbA+numbB+numbC+numbD);
            Console.WriteLine("{3}{2}{1}{0}", numbA, numbB, numbC, numbD);
            Console.WriteLine("{3}{0}{1}{2}", numbA, numbB, numbC, numbD);
            Console.WriteLine("{0}{2}{1}{3}", numbA, numbB, numbC, numbD);
        }
    }
}
