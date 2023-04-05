using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2
{
    internal class cs3
    {
        public static void task_3()
        {
            Console.Write("Write string: ");
            string input = Console.ReadLine();
            int shift = 3; 

            string output = ""; 
            foreach (char c in input)
            {
                if (Char.IsLetter(c))
                { 
                    char shifted = (char)(c + shift); 
                    if (!Char.IsLetter(shifted))
                    { 
                        shifted = (char)(c - 26 + shift); 
                    }
                    output += shifted; 
                }
                else
                {
                    output += c; 
                }
            }

            Console.WriteLine("Encrypted string: " + output);
        }
    }
    
}
