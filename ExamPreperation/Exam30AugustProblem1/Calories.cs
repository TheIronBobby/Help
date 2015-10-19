using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam30AugustProblem1
{
    class Calories
    {
        static void Main()
        {
            double weight = double.Parse(Console.ReadLine()) / 2.2;
            double height = double.Parse(Console.ReadLine()) * 2.54;
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double bmr = 0;

            if (gender == "m")
            {
                bmr = 66.5 + (13.75 * weight) + (5.003 * height) - (6.755 * age);
            }
            else
            {
                bmr = 655 + (9.563 * weight) + (1.850 * height) - (4.676 * age);
            }
            double dci = 0;
            if (count <= 0)
            {
                dci = bmr * 1.2;
            }
            else if (count >= 1 && count <= 3)
        	{
                dci = bmr * 1.375;
        	}
            else if (count >= 4 && count <= 6)
            {
                dci = bmr * 1.55;
            }
            else if (count >= 7 && count <= 9)
            {
                dci = bmr * 1.725;
            }
            else 
            {
                dci = bmr * 1.9;
            }
            Console.WriteLine(Math.Floor(dci));
        }
    }
}
