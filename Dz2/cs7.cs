using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2
{
    internal class cs7
    {
        public static void task_7()
        {
            
            Console.Write("Write text:");
            string text = Console.ReadLine();
            Console.Write("Write fobiddenWords:");
            string[] forbiddenWords = Console.ReadLine().Split(',');

            int replacementsCount = 0; 
                                       
            string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < sentences.Length; i++)
            {
                
                string[] words = sentences[i].Split(new char[] { ' ', ',', ':', ';', '-', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < words.Length; j++)
                {
                    
                    if (Array.IndexOf(forbiddenWords, words[j].ToLower()) >= 0)
                    {
                        
                        sentences[i] = sentences[i].Replace(words[j], "***");
                        replacementsCount++;
                    }
                }
            }

            
            string result = string.Join(". ", sentences) + ".";
            Console.WriteLine("Result: " + result);
            Console.WriteLine("Statistics: " + replacementsCount + " word replacement" );

            

        }
    }
}
