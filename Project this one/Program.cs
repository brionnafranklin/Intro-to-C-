using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_this_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi");
            String playerName;
            int playerScore = 0;

            playerName = Console.ReadLine();

            int add = 0;

            while (playerScore < 10)
                {
                //request input
                Console.Write("Increament Score ");
                add = Convert.ToInt32(Console.ReadLine());
                //add score
                playerScore = playerScore + add;
                Console.Write("Current Score: ");
                Console.WriteLine(playerScore);

            }

            Console.Write("Score of ");
            Console.WriteLine(playerName);
            Console.WriteLine(playerScore);

            Console.ReadLine();
        }

    }
}
