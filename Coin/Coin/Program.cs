using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin
{
    class Program
    {
    
        static void Main(string[] args)
        {


            Console.WriteLine("Choose Heads or Tails");
            string input = Console.ReadLine();

            var rand = new Random();

            var value = rand.Next(0, 2);

            string answer = "";

            if (value == 1)
            {
                answer = (" heads");
            }
            else if (value == 0)
            {
                answer = (" tails");
            }
            if (input == answer)
            {
                Console.WriteLine("Congratulations, you WIN");
            }
            else if (input != answer)
            {
                Console.WriteLine("LOSER!!!");
            }


            Console.ReadKey();

        }
    }
}
