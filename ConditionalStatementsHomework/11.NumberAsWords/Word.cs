using System;


namespace _11.NumberAsWords
{
    class Word
    {
        static void Main()
        {
            Console.WriteLine("Enter number between \"0\" and \"999\"");
            int number = 0;
            do
            {
                number = int.Parse(Console.ReadLine());
            } while (number < 0||number > 999);
            if (number == 0)
            {
                Console.WriteLine("zero");
            }
            int tens = (number / 10) % 10;
            int hundreds = number / 100;
            int ones;
            if (tens == 1)
            {
                ones = number % 100;
            }
            else
            {
                ones = number % 10;
            }
            switch (hundreds)
            {
                case 1: Console.Write("one hundred");
                    break;
                case 2: Console.Write("two hundred");
                    break;
                case 3: Console.Write("three hundred");
                    break;
                case 4: Console.Write("four hundred");
                    break;
                case 5: Console.Write("five hundred");
                    break;
                case 6: Console.Write("six hundred");
                    break;
                case 7: Console.Write("seven hundred");
                    break;
                case 8: Console.Write("eight hundred");
                    break;
                case 9: Console.Write("nine hundred");
                    break;
            }
            if (hundreds > 0 && (tens != 0 || ones != 0))
            {
            Console.Write(" and ");
            }
            else if (hundreds > 0)
            {
            Console.WriteLine();
            }
            switch (tens)
            {
                case 2: Console.Write("twenty");
                    break;
                case 3: Console.Write("thirty");
                    break;
                case 4: Console.Write("forty");
                    break;
                case 5: Console.Write("fifty");
                    break;
                case 6: Console.Write("sixty");
                    break;
                case 7: Console.Write("seventy");
                    break;
                case 8: Console.Write("eighty");
                    break;
                case 9: Console.Write("ninety");
                    break;
            }
            if (tens > 1 && ones != 0)
            {
                Console.Write("-");
            }
            else if (tens > 1 && ones == 0)
            {
                Console.WriteLine();
            }
            switch (ones)
            {
                case 1: Console.WriteLine("one");
                    break;
                case 2: Console.WriteLine("two");
                    break;
                case 3: Console.WriteLine("three");
                    break;
                case 4: Console.WriteLine("four");
                    break;
                case 5: Console.WriteLine("five");
                    break;
                case 6: Console.WriteLine("six");
                    break;
                case 7: Console.WriteLine("seven");
                    break;
                case 8: Console.WriteLine("eight");
                    break;
                case 9: Console.WriteLine("nine");
                    break;
                case 10: Console.WriteLine("ten");
                    break;
                case 11: Console.WriteLine("eleven");
                    break;
                case 12: Console.WriteLine("twelve");
                    break;
                case 13: Console.WriteLine("thirteen");
                    break;
                case 14: Console.WriteLine("fourteen");
                    break;
                case 15: Console.WriteLine("fifteen");
                    break;
                case 16: Console.WriteLine("sixteen");
                    break;
                case 17: Console.WriteLine("seventeen");
                    break;
                case 18: Console.WriteLine("eighteen");
                    break;
                case 19: Console.WriteLine("nineteen");
                    break;
            }
        }
    }
}
