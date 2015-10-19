using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam29MarchEveningProblem4
{
    class ArrayMatcher
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split('\\');

            char[] firstArray = input[0].ToCharArray();
            char[] secondArray = input[1].ToCharArray();
            string comand = input[2];

            List<char> newArray = new List<char>();

            if (comand == "join")
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (secondArray.Contains(firstArray[i]))
                    {
                        newArray.Add(firstArray[i]);
                    }
                }
            }
            else if (comand == "right exclude")
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (!secondArray.Contains(firstArray[i]))
                    {
                        newArray.Add(firstArray[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                    if (!firstArray.Contains(secondArray[i]))
                    {
                        newArray.Add(secondArray[i]);
                    }
                }
            }
            newArray.Sort();
            foreach (var element in newArray)
            {
                Console.Write(element);
            }
        }
    }
}
