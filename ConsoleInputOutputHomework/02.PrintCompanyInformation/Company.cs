using System;

namespace _02.PrintCompanyInformation
{
    class Company
    {
        static void Main()
        {
            Console.Write("Enter company's name: ");
            string companyName = Console.ReadLine();
            Console.Write("Enter company's adres: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Enter company's phone number: ");
            string phoneNumb = Console.ReadLine();
            Console.Write("Enter company's fax number: ");
            string companyFax = Console.ReadLine();
            Console.Write("Enter company's web site: ");
            string companyWebSite = Console.ReadLine();
            Console.Write("Enter manager's first name: ");
            string managerFN = Console.ReadLine();
            Console.Write("Enter manager's last name: ");
            string managerLN = Console.ReadLine();
            Console.Write("Enter manager's age: ");
            int managerAge = int.Parse(Console.ReadLine());
            Console.Write("Enter manager's phone number: ");
            string managerPhoneNumb = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Tel. {0}", phoneNumb);
            if (companyFax == "")
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine(companyFax);
            }
            Console.WriteLine("Web site: {0}", companyWebSite);
            Console.WriteLine("Manager: {0} {1}(age: {2}, tel. {3})", managerFN, managerLN, managerAge, managerPhoneNumb);

        }
    }
}
