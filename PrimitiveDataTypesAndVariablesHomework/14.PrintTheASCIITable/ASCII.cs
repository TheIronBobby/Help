using System;


namespace _14.PrintTheASCIITable
{
    class ASCII
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            for (int i = 0; i < 226; i++)
            {
                char asciiElement = (char)i;
                Console.WriteLine("The charakter \"{0}\" is number {1} in the ASCII tabel.", asciiElement, i);
            }
	        

        }
    }
}
