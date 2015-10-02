using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PlayWithIntDoubleAndString
{
    class Menu
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Please enter a int: ");
                    double user = int.Parse(Console.ReadLine());
                    Console.WriteLine(user+1);
                    break;
                case "2":
                    Console.WriteLine("Please enter a double:");
                    user = double.Parse(Console.ReadLine());
                    Console.WriteLine(user+1);
                    break;
                case "3":
                    Console.WriteLine("Please enter a string:");
                    string input = Console.ReadLine();
                    Console.WriteLine("{0}*",input);
                    break;
                default:
                    Console.WriteLine("Invalid type");
                    break;
            }
        }
    }
}
