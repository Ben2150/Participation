using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_LoopParticipation
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumber;

            while (true) ;
            {
                randomNumber = rand.Next(0, 2);
                Console.WriteLine(randomNumber);

                Console.WriteLine("Enter Heads or Tails >>");
                string usersGuessAsString = Console.ReadLine();
                int usersGuess;
                const int Heads_Value = 0;
                const int Tails_Value = 0;
                if (usersGuessAsString == "Heads")
                else if (usersGuessAsString == "Tails")
                else

                if (usersGuess == randomNumber)
                {
                    Console.WriteLine
                }
            }
        }
    }
}
