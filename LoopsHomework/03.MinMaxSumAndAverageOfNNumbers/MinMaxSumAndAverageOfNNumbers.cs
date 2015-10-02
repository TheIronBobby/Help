using System;

namespace _03.MinMaxSumAndAverageOfNNumbers
{
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            Console.Write("Enter n=");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int minNumber = numbers[0];
            int maxNumber = numbers[0];
            for (int i = 1; i < n; i++)
            {
                if (minNumber > numbers[i])
                {
                    minNumber = numbers[i]; 
                }
                if (maxNumber < numbers[i])
                {
                    maxNumber = numbers[i];
                }
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += numbers[i];
            }
            double average = (double)sum / n;
            Console.WriteLine("min = {0}",minNumber);
            Console.WriteLine("max = {0}",maxNumber);
            Console.WriteLine("sum = "+ sum);
            Console.WriteLine("avg = {0:0.00}",average);
        }
    }
}
