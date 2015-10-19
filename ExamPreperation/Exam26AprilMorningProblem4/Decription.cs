using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam26AprilMorningProblem4
{
    class Decription
    {
        static void Main()
        {
            string comand = Console.ReadLine();
            while (comand != "start" && comand != "START")
            {
                comand = Console.ReadLine();
            }

            comand = Console.ReadLine();

            int countMessages = 0;
            string decriptedMessage = string.Empty;

            while (comand != "end" && comand != "END")
            {
                if (string.IsNullOrWhiteSpace(comand))
                {
                    comand = Console.ReadLine();
                    continue;
                }
                for (int i = comand.Length - 1; i >= 0; i--)
                {
                    char currentSymbol = comand[i];
                    if ((currentSymbol >= 'a' && currentSymbol <= 'm') || (currentSymbol >= 'A' && currentSymbol <= 'M'))
                    {
                        decriptedMessage += (char)(currentSymbol + 13);
                    }
                    else if ((currentSymbol >= 'n' && currentSymbol <= 'z') || (currentSymbol >= 'N' && currentSymbol <= 'Z'))
                    {
                        decriptedMessage += (char)(currentSymbol - 13);
                    }
                    else if (currentSymbol >= '0' && currentSymbol <= '9')
                    {
                        decriptedMessage += currentSymbol;
                    }
                    else
                    {
                        switch (currentSymbol)
                        {
                            case '+':
                                decriptedMessage += ' ';
                                break;
                            case '%':
                                decriptedMessage += ',';
                                break;
                            case '&':
                                decriptedMessage += '.';
                                break;
                            case '#':
                                decriptedMessage += '?';
                                break;
                            case '$':
                                decriptedMessage += '!';
                                break;
                            default:
                                break;
                        }
                    }
                }
                decriptedMessage += Environment.NewLine;
                countMessages++;
                
                comand = Console.ReadLine();
            }
            if (countMessages == 0)
            {
                Console.WriteLine("No message received.");
            }
            else
            {
                Console.WriteLine("Total number of messages: {0}",countMessages);
                Console.WriteLine(decriptedMessage);
            }
        }
    }
}
