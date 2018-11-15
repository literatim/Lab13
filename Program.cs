using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Validator.GetUserName(userName);

            do
            {
                string playerSelection = RoshamboApp.StartRoshamboApp();

                string userRoshambo = UserPlayer.GenerateRoshambo();

                UserPlayer player = new UserPlayer(userName, userRoshambo);

                int roshamboValue = 0;

                if (playerSelection == "b")
                {
                    roshamboValue = Bababooie.GetRoshamboValue();
                    playerSelection = "Bababooie";

                }

                if (playerSelection == "l")
                {
                    roshamboValue = 1;
                    playerSelection = "Left Shark";
                }

                Console.WriteLine($"{player.UserName}: {player.RoshamboValue}");
                Console.WriteLine($"{playerSelection}: {roshamboValue}");

                if (userRoshambo == "1" && roshamboValue == 1)
                {
                    Console.WriteLine("Draw!");
                }
                if ((userRoshambo == "1" && roshamboValue == 2) || (userRoshambo == "2" && roshamboValue = 1))
                {
                    Console.WriteLine($"{playerSelection} wins!");
                }
                if ((userRoshambo == "1" && roshamboValue == 3) || (userRoshambo == "2" && roshamboValue = 1))
                {
                    Console.WriteLine($"{player.UserName} wins!");
                }
                if (userRoshambo == "2" && roshamboValue == 1)
                {
                    Console.WriteLine("Draw!");
                }


                Console.Write("Play again? (y/n): ");
            } while (Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase));


            Console.WriteLine("Goodbye.");
            Console.ReadKey();
        }
    }
}
