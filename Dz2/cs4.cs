using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2
{
    internal class cs4
    {
        public static void task_4()
        {
            int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] matrix2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };

            
            Console.WriteLine("Матриця 1:");
            PrintMatrix(matrix1);
            
            Console.WriteLine("Матриця 2:");
            PrintMatrix(matrix2);

            Console.WriteLine("Множення матрицi 1 на число 2:");
            int[,] result1 = MultiplyMatrix(matrix1, 2);
            PrintMatrix(result1);

            Console.WriteLine("Додавання матриць 1 i 2:");
            int[,] result2 = AddMatrices(matrix1, matrix2);
            PrintMatrix(result2);

            Console.WriteLine("Добуток матриць 1 i 2:");
            int[,] result3 = MultiplyMatrices(matrix1, matrix2);
            PrintMatrix(result3);
        }

        
        static int[,] MultiplyMatrix(int[,] matrix, int scalar)
        {
            int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }
            return result;
        }

        
        static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }

        
        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
