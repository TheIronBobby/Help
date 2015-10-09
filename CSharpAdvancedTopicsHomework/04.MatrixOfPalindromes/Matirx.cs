using System;


namespace _04.MatrixOfPalindromes
{
    class Matirx
    {
        static void Main()
        {
            Console.WriteLine("Enter number of rows and colums in the matrix:");
            int row = int.Parse(Console.ReadLine());
            int colum = int.Parse(Console.ReadLine());
            char firstLetter = 'a';
            for (char i = 'a'; i < firstLetter+row; i++)
            {
                for (char j = i; j < i+colum; j++)
                {
                    string leters = i.ToString() + j.ToString() + i.ToString();
                    Console.Write(leters+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
