using System;


namespace _12.ZeroSubset
{
    class ZeroSubset
    {
        static void Main()
        {
            int[] numbers = new int[5];
            Console.WriteLine("Enter five numbers, each on a new line:");
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int counter = 0;
            Console.WriteLine("Result:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (numbers[i]+numbers[j]==0)
                    {
                        Console.WriteLine("{0} + {1} = 0", numbers[i], numbers[j]);
                        counter++;
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    for (int k = j + 1; k < 5; k++)
                    {
                        if (numbers[i] + numbers[j] + numbers[k] == 0)
                        {
                           Console.WriteLine("{0} + {1} + {2} = 0", numbers[i], numbers[j], numbers[k]);
                           counter++;
                        }
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = i + 1 ; j < 3; j++)
                {
                    for (int k = j + 1; k < 4; k++)
                    {
                        for (int l = k + 1; l < 5; l++)
                        {
                            if (numbers[i] + numbers[j] + numbers[k] + numbers[l] == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[i], numbers[j], numbers[k], numbers[l]);
                                counter++;
                            }
                        }
                    }
                }
            }
            if (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
                counter++;
            }


            if (counter == 0)
            {
                Console.WriteLine("no zero subset");
            }

        }
    }
}
