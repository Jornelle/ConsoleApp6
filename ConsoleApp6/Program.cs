using System;

namespace ConsoleProjectForTests
{
    class Program
    {
       
        static void Main()
        {
            var random = new Random();
            var matrix = new int[6, 6];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-10, 10);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            var result = new int[matrix.GetLength(1)];

            for (int i = 0; i < result.Length; i++)
                result[i] = 1;

            for (int i = 0; i < matrix.GetLength(1); i++)
                for (int j = 0; j < matrix.GetLength(0); j++)
                    if (matrix[i,j] > 0)
                    {
                        result[i] += matrix[j, i];
                    }
            Console.WriteLine();
            foreach (var element in result)
                Console.Write(element + " ");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}