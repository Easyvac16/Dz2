using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2
{
    internal class cs2
    {
        public static void task_2()
        {
            int[,] matrix = new int[5, 5];

            
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-100, 101);
                }
            }

            
            int minElement = matrix[0, 0];
            int maxElement = matrix[0, 0];
            int minI = 0, minJ = 0, maxI = 0, maxJ = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < minElement)
                    {
                        minElement = matrix[i, j];
                        minI = i;
                        minJ = j;
                    }
                    if (matrix[i, j] > maxElement)
                    {
                        maxElement = matrix[i, j];
                        maxI = i;
                        maxJ = j;
                    }
                }
            }

            
            int sum = 0;
            int startI = Math.Min(minI, maxI) + 1;
            int endI = Math.Max(minI, maxI);
            int startJ = Math.Min(minJ, maxJ) + 1;
            int endJ = Math.Max(minJ, maxJ);
            for (int i = startI; i < endI; i++)
            {
                for (int j = startJ; j < endJ; j++)
                {
                    sum += matrix[i, j];
                }
            }

            
            Console.WriteLine("Matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,5}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Minimum element: {minElement} ({minI}, {minJ})");
            Console.WriteLine($"Maximum element: {maxElement} ({maxI}, {maxJ})");
            Console.WriteLine($"Sum of elements between min and max: {sum}");

           
        }
    }
    
}
