using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2
{
    internal class cs1
    {
        public static void task_1()
        {
            float[] A = new float[5];
            float[,] B = new float[3, 4];

            
            Console.WriteLine("Write 5 numbers array A:");
            for (int i = 0; i < 5; i++)
            {
                A[i] = float.Parse(Console.ReadLine());
            }

            
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = (float)rnd.NextDouble() * 10;
                }
            }

            
            Console.WriteLine("array A:");
            foreach (float a in A)
            {
                Console.Write("{0} ", a);
            }
            Console.WriteLine();

            
            Console.WriteLine("array B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}\t", B[i, j]);
                }
                Console.WriteLine();
            }

            
            float max = A[0], min = A[0];
            for (int i = 0; i < 5; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
                if (A[i] < min)
                {
                    min = A[i];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (B[i, j] > max)
                    {
                        max = B[i, j];
                    }
                    if (B[i, j] < min)
                    {
                        min = B[i, j];
                    }
                }
            }
            Console.WriteLine($"Total maximum element: {max}");
            Console.WriteLine($"Total minimum element: {min}");

            
            float sum = 0, product = 1;
            foreach (float a in A)
            {
                sum += a;
                product *= a;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum += B[i, j];
                    product *= B[i, j];
                }
            }
            Console.WriteLine($"Total sum of all elements: {sum}");
            Console.WriteLine($"The total product of all elements: {product}");

            float evenSum = 0;
            for (int i = 0; i < 5; i++)
            {
                if (A[i] % 2 == 0)
                {
                    evenSum += A[i];
                }
            }
            Console.WriteLine($"The sum of even elements of the array A: {evenSum}");

            
            float oddColumnsSum = 0;
            for (int j = 0; j < 4; j++)
            {
                if (j % 2 == 1)
                { 
                    for (int i = 0; i < 3; i++)
                    {
                        oddColumnsSum += B[i, j];
                    }
                }
            }
            Console.WriteLine($"\r\nThe sum of the odd columns of the array B: {oddColumnsSum}");
        }
    }
    
}
