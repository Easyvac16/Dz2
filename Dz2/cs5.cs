using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2
{
    internal class cs5
    {
        public static void task_5()
        {

            int result = 0;
            int term = 0;
            char op = '+';
            Console.Write("Enter an arithmetic expression: ");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (Char.IsDigit(c))
                {
                    term = term * 10 + (c - '0');
                }
                if (!Char.IsDigit(c) && c != ' ' || i == input.Length - 1)
                {
                    if (op == '+')
                    {
                        result += term;
                    }
                    else if (op == '-')
                    {
                        result -= term;
                    }
                    term = 0;
                    op = c;
                }
            }
            Console.WriteLine("Result: " + result);
        }
    }
}
