using System;

namespace _15.HexadecimalToDecimalNumber
{
    class HexademicalToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter hexademical number");
            string hexNumb = Console.ReadLine();
            long decNumb = 0;
            int num = 0;
            int exponent = hexNumb.Length - 1;
            for (int i = 0; i < hexNumb.Length; i++)
            {
                char ch = hexNumb[i];
                switch (ch)
                {
                    case 'A':
                    case 'a':
                        num = 10;
                        break;
                    case 'B':
                    case 'b':
                        num = 11;
                        break;
                    case 'C':
                    case 'c':
                        num = 12;
                        break;
                    case 'D':
                    case 'd':
                        num = 13;
                        break;
                    case 'E':
                    case 'e':
                        num = 14;
                        break;
                    case 'F':
                    case 'f':
                        num = 15;
                        break;
                    default:
                        num = Convert.ToInt16(ch);
                        break;

                }
                decNumb += num * (long)Math.Pow(16, exponent);
                exponent--;
            }
            Console.WriteLine(decNumb);
        }
    }
}
