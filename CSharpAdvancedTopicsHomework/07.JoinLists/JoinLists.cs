using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.JoinLists
{
    class JoinLists
    {
        static void Main()
        {
            Console.WriteLine("Enter first list of numbers:");
            string firstInput = Console.ReadLine();
            Console.WriteLine("Enter the second list of numbers:");
            string secondInput = Console.ReadLine();
            Console.WriteLine();
            List<int> firstList = firstInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToList();
            List<int> secondList = secondInput.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToList();
            var result = firstList.Union(secondList).ToList();
            result.Sort();
            foreach (var number in result)
            {
                Console.Write("{0} ",number);
            }
            Console.WriteLine();
        }
    }
}
