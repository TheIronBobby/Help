using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LongestWordInAText
{
    class LongestWord
    {
        static void Main()
        {
            Console.WriteLine("Enter your text:");
            string text = Console.ReadLine();
            string[] array = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string biggestWord = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (biggestWord.Length<array[i].Length)
                {
                    biggestWord = array[i];
                }
            }
            Console.WriteLine(biggestWord);
        }
    }
}
