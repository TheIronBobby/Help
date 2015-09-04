using System;

namespace _8.Isosceles_Triangle
{
    class Triangle
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Enter number of lines: " );
            int lines = int.Parse(Console.ReadLine());
            char copyright = '\u00A9';
            Console.Write(new string(' ',lines - 1));
            Console.Write(copyright);
            Console.WriteLine(new string(' ', lines - 1));
            for (int i = 2; i <= lines - 1; i++)
            {
                int numbersOfSpaces = lines - i; 
                int spacesBetweenCopy = (i * 2) - 3;  

                Console.Write(new string(' ', numbersOfSpaces));
                Console.Write(copyright);
                Console.Write(new string(' ', spacesBetweenCopy));
                Console.Write(copyright);
                Console.WriteLine(new string(' ', numbersOfSpaces));
            }
            for (int j = 0; j <= lines - 1; j++)
            {
                Console.Write(new string (copyright, 1));
                Console.Write(new string (' ',1));
            }
        }
    }
}
