using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class FirefightingOrganization
    {
        static void Main()
        {
            int firefighters = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            int savedKids = 0;
            int savedAdults = 0;
            int savedSeniors = 0;
            char[] building = comand.ToCharArray();
            while (comand!="rain")
            {
               int firefightersLeft = firefighters;
                building = comand.ToCharArray();
                for (int i = 0; i < building.Length; i++)
                {
                    if (building[i] == 'K')
                    {
                        if (firefightersLeft == 0)
                        {
                            break;
                        }
                        savedKids++;
                        firefightersLeft--;
                    }
                }
                for (int i = 0; i < building.Length; i++)
                {
                    if (building[i] == 'A')
                    {
                        if (firefightersLeft == 0)
                        {
                            break;
                        }
                        savedAdults++;
                        firefightersLeft--;
                    }
                }
                for (int i = 0; i < building.Length; i++)
                {
                    if (building[i]=='S')
                    {
                        if (firefightersLeft == 0)
                        {
                            break;
                        }
                        savedSeniors++;
                        firefightersLeft--;
                    }
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine("Kids: {0}",savedKids);
            Console.WriteLine("Adults: {0}",savedAdults);
            Console.WriteLine("Seniors: {0}",savedSeniors);
        }
    }
}
