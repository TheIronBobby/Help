using System;


namespace _09.MatrixOfNumbers
{
    class Matrix
    {
        static void Main()
        {
            int number;
            do
            {
                Console.Write("Enter n=");
                number = int.Parse(Console.ReadLine());
            } while (number<1||number>20);

            for (int i = 1; i <= number; i++)
            {
                for (int j = i; j <= (number+i)-1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
