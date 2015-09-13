using System;
using System.Globalization;
using System.Threading;


namespace _05.FormatingNumbers
{
    class Format
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            int a;          
            do
            {
                Console.Write("Enter number between 0 and 500 a=");
                a= int.Parse(Console.ReadLine()); 
            }while(a < 0 | a > 500);

            Console.Write("Enter number b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter number c=");
            double c = double.Parse(Console.ReadLine());
            string binary = Convert.ToString(a, 2).PadLeft(10,'0');
            Console.WriteLine("|{0,-10:X}|{1,10}|{2,10:0.00}|{3,-10:0.000}|",a,binary,b,c);
        }
    }
}
