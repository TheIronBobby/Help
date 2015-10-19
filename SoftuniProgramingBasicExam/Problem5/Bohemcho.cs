using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Bohemcho
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            ulong floorState = 0;
            ulong newState = 0;
            ulong countLightOn = 0;
            ulong score = 0;
            
            List<int> apartments = new List<int>();
            while (inputLine != "Stop, God damn it")
            {
                floorState = uint.Parse(inputLine);
                newState = floorState;
                apartments = new List<int>(Array.ConvertAll(Console.ReadLine()
                    .Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries), int.Parse));
                foreach (var item in apartments)
                {
                    newState = (newState ^ ((ulong)1 << item));
                }
                score += newState;

                for (int i = 0; i < 64; i++)
			    {
			        if ((newState&((ulong)1<<i))!=0)
	                    {
                            countLightOn++;
	                    }
			    }
                inputLine = Console.ReadLine();
                 
            }
            
            Console.WriteLine("Bohemcho left {0} lights on and his score is {1}",countLightOn ,score);
        }
    }
}
