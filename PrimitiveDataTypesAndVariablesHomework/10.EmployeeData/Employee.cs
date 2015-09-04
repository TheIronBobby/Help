using System;

namespace _10.EmployeeData
{
    class Employee
    {
        static void Main()
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            byte age = 27;
            char sex = 'f';
            ulong iD = 8306112507;
            uint employeeNumber = 27563571;
            Console.WriteLine("First Name: {0}",firstName);
            Console.WriteLine("Last Name: {0}",lastName);
            Console.WriteLine("Age: {0}",age);
            Console.WriteLine("Sex: {0}",sex);
            Console.WriteLine("Personal ID: {0}",iD);
            Console.WriteLine("Unique Employee number: {0}", employeeNumber);
        }
    }
}
