using System;

namespace _6.StringAndObjects
{
    class Hello
    {
        static void Main()
        {
            string word0 = "Hello";
            string word1 = "World";
            object together = word0 + ' ' + word1;
            string sentence = (string)together;
            Console.WriteLine(together);
        }
    }
}
