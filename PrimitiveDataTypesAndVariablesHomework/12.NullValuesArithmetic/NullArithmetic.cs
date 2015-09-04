using System;

namespace _12.NullValuesArithmetic
{
    class NullArithmetic
    {
        static void Main()
        {
            int? number0 = null;
            double? number1 = null;
            Console.WriteLine("{0} {1}", number0, number1);
            number0 += 18;
            number1 += null;
            Console.WriteLine("{0} {1}", number0, number1);
        }
    }
}
