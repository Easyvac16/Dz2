using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2
{
    internal class cs6
    {
        public static void task_6()
        {
            Console.Write("Enter a text: ");
            string input = Console.ReadLine();

            string[] sentences = input.Split('.');
            string result = "";
            foreach (string sentence in sentences)
            {
                if (sentence.Trim() != "")
                {
                    string firstChar = sentence.Trim().Substring(0, 1);
                    string rest = sentence.Trim().Substring(1);
                    result += firstChar.ToUpper() + rest + ". ";
                }
            }
            
            Console.WriteLine("Result: " + result.Trim());



        }
    }
}
