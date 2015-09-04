using System;


namespace _7.QuotesInStrings
{
    class Quotes
    {
        static void Main()
        {
            string one = "The \"use\" of quotations causes difficulties.";
            string two = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(one);
            Console.WriteLine(two);
        }
    }
}
