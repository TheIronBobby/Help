﻿using System;
using System.Collections.Generic;

namespace _13.ComparingFloats
{
    class Comparing
    {
        static void Main()
        {
           
            List<double> floatPointNumb1 = new List<double> { 5.3, 5.00000001, 5.00000005, -0.0000007, -4.999999, 4.999999 };
            List<double> floatPointNumb2 = new List<double> { 6.01, 5.00000003, 5.00000001, 0.00000007, -4.999998, 4.999998 };
            
            double eps = 0.000001;
            for (int i = 0; i < 6; i++)
            {
                double diff = Math.Abs(floatPointNumb1[i] - floatPointNumb2[i]);
                if (diff <= eps)
                {
                    Console.WriteLine("Is number {0} and number {1} equal?: true",floatPointNumb1[i],floatPointNumb2[i]);
                }
                else
                {
                    Console.WriteLine("Is number {0} and number {1} equal?: false", floatPointNumb1[i], floatPointNumb2[i]);
                }
            }
        }
    }
}
