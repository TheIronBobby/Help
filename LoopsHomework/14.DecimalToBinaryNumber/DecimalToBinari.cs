using System;


namespace _14.DecimalToBinaryNumber
{
    class DecimalToBinari
    {
        static void Main()
        {
            Console.WriteLine("Enter a decimal number");
            long number = long.Parse(Console.ReadLine());
            long result = 0;
            string binary = string.Empty;
            while (number!=0)
            {
                result = number % 2;
                number /= 2;
                binary += result.ToString();
            }
            char[] revers = binary.ToCharArray();
            Array.Reverse(revers);
            for (int i = 0; i < binary.Length; i++)
            {
                Console.Write("{0}",revers[i]);
            }
            Console.WriteLine();
        }
    }
}
