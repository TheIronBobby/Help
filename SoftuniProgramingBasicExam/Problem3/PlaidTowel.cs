using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class PlaidTowel
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char background = Console.ReadLine()[0];
            char rombus = Console.ReadLine()[0];
            int outerSimbol = size;
            int inerSimbol = 1;
            int middleSimbol = size * 2 - 1;

            Console.WriteLine("{0}{1}{2}{1}{0}", new string(background, size), rombus, new string(background, size * 2 - 1));
            for (int i = size-1; i > 0; i--)
            {
                outerSimbol = i;
                middleSimbol -= 2;
                Console.WriteLine("{0}"+rombus+"{1}"+rombus+"{2}"+rombus+"{1}"+rombus+"{0}",
                    new string(background, outerSimbol),new string(background,inerSimbol),new string(background,middleSimbol));
                inerSimbol += 2;            
            }
            Console.WriteLine(rombus + "{0}" + rombus + "{0}" + rombus, new string(background, size*2-1));
            inerSimbol -= 2;
            for (int i = 1; i < size; i++)
            {
                outerSimbol = i;
                Console.WriteLine("{0}"+rombus+"{1}"+rombus+"{2}"+rombus+"{1}"+rombus+"{0}",
                    new string(background, outerSimbol),new string(background,inerSimbol),new string(background,middleSimbol));
                inerSimbol -= 2;
                middleSimbol += 2;
                
            }
            Console.WriteLine("{0}{1}{2}{1}{0}", new string(background, size), rombus, new string(background, size * 2 - 1));
            outerSimbol = size;
            inerSimbol = 1;
            middleSimbol = size * 2 - 1;
            for (int i = size - 1; i > 0; i--)
            {
                outerSimbol = i;
                middleSimbol -= 2;
                Console.WriteLine("{0}" + rombus + "{1}" + rombus + "{2}" + rombus + "{1}" + rombus + "{0}",
                    new string(background, outerSimbol), new string(background, inerSimbol), new string(background, middleSimbol));
                inerSimbol += 2;
            }
            Console.WriteLine(rombus + "{0}" + rombus + "{0}" + rombus, new string(background, size * 2 - 1));
            inerSimbol -= 2;
            for (int i = 1; i < size; i++)
            {
                outerSimbol = i;
                Console.WriteLine("{0}" + rombus + "{1}" + rombus + "{2}" + rombus + "{1}" + rombus + "{0}",
                    new string(background, outerSimbol), new string(background, inerSimbol), new string(background, middleSimbol));
                inerSimbol -= 2;
                middleSimbol += 2;

            }
            Console.WriteLine("{0}{1}{2}{1}{0}", new string(background, size), rombus, new string(background, size * 2 - 1));
        }
    }
}
