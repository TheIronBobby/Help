using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam26AprilEveningProblem1
{
    class CompoundInterest
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            decimal priceTv = decimal.Parse(Console.ReadLine());
            int numbOfYears = int.Parse(Console.ReadLine());
            double bankInterest = double.Parse(Console.ReadLine());
            double friendInterest = double.Parse(Console.ReadLine());

            decimal bankLoan = priceTv * (decimal)(Math.Pow((1 + bankInterest), numbOfYears));
            decimal friendLoan = priceTv * (decimal)(1 + friendInterest);
            if (bankLoan >= friendLoan)
            {
                Console.WriteLine("{0:F2} Friend",friendLoan);
            }
            else
            {
                Console.WriteLine("{0:F2} Bank",bankLoan);
            }
        }
    }
}
