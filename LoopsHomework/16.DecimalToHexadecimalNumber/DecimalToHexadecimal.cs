using System;

namespace _16.DecimalToHexadecimalNumber
{
    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer number:");
            long decNumb = long.Parse(Console.ReadLine());
            long result = 0;
            string revers = string.Empty;
            while (decNumb != 0)
            {
                result = decNumb % 16;
                decNumb /= 16;
                switch (result)
                {
                    case 10:
                        revers += 'A';
                        break;
                    case 11:
                        revers += 'B';
                        break;
                    case 12:
                        revers += 'C';
                        break;
                    case 13:
                        revers += 'D';
                        break;
                    case 14:
                        revers += 'E';
                        break;
                    case 15:
                        revers += 'F';
                        break;
                    default:
                        revers += result.ToString();
                        break;
                }
            }
            char[] hexNumb = revers.ToCharArray();
            Array.Reverse(hexNumb);
            for (int i = 0; i < hexNumb.Length; i++)
            {
                Console.Write("{0}",hexNumb[i]);
            }
            Console.WriteLine();
        }
    }
}
