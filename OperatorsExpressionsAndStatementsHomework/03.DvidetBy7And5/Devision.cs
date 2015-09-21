using System;


namespace _03.DvidetBy7And5
{
    class Devision
    {
        static void Main()
        {
            Console.Write("Enter a number ");
            int numb = int.Parse(Console.ReadLine());
            bool ans = numb % 7 == 0 && numb % 5 == 0;
            Console.WriteLine(ans);
        }
    }
}
