using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LongestAreaInArray
{
    class LongestAreaInArray
    {
        static void Main()
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            string[] array = new string[numberOfElements];
            int count = 0;
            string index = "";
            string highestIndex = "";
            bool isItExecuted = false;
            for (int i = 0; i < numberOfElements; i++)
            {
                array[i] = Console.ReadLine();
            }
            for (int i = 0; i < numberOfElements; i++)
            {
                for (int j = i+1; j < numberOfElements; j++)
                {
                    if (array[i] == array[j])
                    {
                        if (i == numberOfElements-1)
                        {
                            i = j;
                        }
                        if (count == 0)
                        {
                            index += i;
                        }
                        count++;
                        index += " " + j;
                        isItExecuted = true;
                    }
                    else
                    {
                        count = 0;
                        i = j;
                        if (index.Length > highestIndex.Length)
                        {
                            highestIndex = index;
                        }
                        index = "";
                    }
                }
            }
            if (index.Length > highestIndex.Length)
            {
                highestIndex = index;
            }
            if (isItExecuted == false)
            {
                highestIndex = "0";
            }
            List<string> indexesToWrite = highestIndex.Split(' ').ToList();

            Console.WriteLine();
            Console.WriteLine(indexesToWrite.Count);
            foreach (string result in indexesToWrite) 
            {
                Console.WriteLine(array[Convert.ToInt32(result)]);
            }
        }
    }
}
