using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RemoveNames
{
    class RemoveNames
    {
        static void Main()
        {
            Console.WriteLine("Enter the firs list of names:");
            string input1 = Console.ReadLine();
            List<string> firstListOfNames = input1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Console.WriteLine("Enter the names that you want to remove:");
            string removeInput = Console.ReadLine();
            List<string> secondList = removeInput.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = 0; i < secondList.Count; i++)
            {
                for (int j = 0; j < firstListOfNames.Count; j++)
                {
                    if (secondList[i] == firstListOfNames[j])
                    {
                        firstListOfNames.Remove(firstListOfNames[j]);
                    }
                }
            }
            foreach (string name in firstListOfNames)
            {
                Console.Write("{0} ",name);
            }
            Console.WriteLine();
        }
    }
}
