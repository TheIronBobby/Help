using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam29MarchEveningProblem2
{
    class DreamItem
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] data = input.Split(new char[] { '\\' });
            decimal moneyPerHour = decimal.Parse(data[1]);
            int hoursPerDay = int.Parse(data[2]);
            decimal priceOfItem = decimal.Parse(data[3]);
            decimal income = 0;

            switch (data[0])
            {
                case "Jan":
                case "March":
                case "May":
                case "July":
                case "Aug":
                case "Oct":
                case "Dec":
                    income = 21m * moneyPerHour * hoursPerDay;
                break;
                case "Apr":
                case "June":
                case "Sept":
                case "Nov":
                    income = 20m * moneyPerHour * hoursPerDay;
                break;
                case "Feb":
                    income = 18m * moneyPerHour * hoursPerDay;
                break;
            }
            if (income > 700)
            {
                income += income * 0.1m;
            }
            if (income >= priceOfItem)
            {
                Console.WriteLine("Money left = {0:F2} leva.",income - priceOfItem);
            }
            else
            {
                Console.WriteLine("Not enough money. {0:F2} leva needed.",priceOfItem - income);
            }
        }
    }
}
