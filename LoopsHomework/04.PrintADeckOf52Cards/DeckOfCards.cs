using System;


namespace _04.PrintADeckOf52Cards
{
    class DeckOfCards
    {
        static void Main()
        {
            string card = "0";
            string[] face = { "\u2660", "\u2665", "\u2666","\u2663" };
            for (int count = 2; count < 15; count++)
            {
                switch (count)
                {
                    case 2:
                    card = "2";
                    break;
                    case 3:
                    card = "3";
                    break;
                    case 4:
                    card = "4";
                    break;
                    case 5:
                    card = "5";
                    break;
                    case 6:
                    card = "6";
                    break;
                    case 7:
                    card = "7";
                    break;
                    case 8:
                    card = "8";
                    break;
                    case 9:
                    card = "9";
                    break;
                    case 10:
                    card = "10";
                    break;
                    case 11:
                    card = "J";
                    break;
                    case 12:
                    card = "Q";
                    break;
                    case 13:
                    card = "K";
                    break;
                    case 14:
                    card = "A";
                    break;
                }
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}{1} ",card,face[j]);
                }
                Console.WriteLine();
            }
 
        }
    }
}
