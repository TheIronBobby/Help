using System;

namespace _03.CheckForAPlayCard
{
    class Card
    {
        static void Main()
        {
            string card = Console.ReadLine();
            switch (card)
            {
                case "A":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                    Console.WriteLine("Yes");
                    break;
                default:
                    Console.WriteLine("No");
                    break;
            }
        }
    }
}
