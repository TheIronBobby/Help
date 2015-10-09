using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExtractURLsFromText
{
    class ExtractURLs
    {
        static void Main()
        {
            Console.WriteLine("Enter your text:");
            string text = Console.ReadLine();
            Console.WriteLine();
            var links = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Where(s => s.StartsWith("http://") || s.StartsWith("www.") || s.StartsWith("https://"));
            foreach (var link in links)
            {
                Console.WriteLine(link);
            }
        }
    }
}
