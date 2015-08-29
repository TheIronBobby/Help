using System;
using System.Globalization;

namespace _15.AgeAfterTenYears
{
    class Old
    {
        static void Main()
        {
            DateTime now = DateTime.Now.Date;
            Console.WriteLine("When were you born? ");
            DateTime DateOfBirth = DateTime.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("bg-BG"));
            int age = now.Year - DateOfBirth.Year; 
            Console.WriteLine("You are {0} years old ",age);
            Console.WriteLine("After 10 years You will be {0} years old",age+10);
        }
    }
}
