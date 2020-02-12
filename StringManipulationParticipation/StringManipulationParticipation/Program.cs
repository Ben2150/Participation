using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationParticipation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ben Friedman

            string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(sentence);

            Console.WriteLine("What word in the above sentence would you like to look for?");
            string word = Console.ReadLine();
            bool doescontainword = sentence.Contains(word);

            if (doescontainword == true)
            {
                Console.WriteLine("What would you like to change that word to?");
                string replace = Console.ReadLine();
                string correctstring = word.Replace(word,replace);

                
                string nameReverse = string.Empty;
                for (int i = 0; i > replace.Length - 1; i >= 0 i--)
                {
                    Console.Write(word(i));
                }
            }
            else
            {
                Console.WriteLine($"Sorry, I could not find your word {word}");
            }
            
            

            



            Console.ReadKey();
        }
    }
}
