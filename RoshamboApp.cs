using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    public enum Roshambo { Rock = 1, Paper, Scissors}
    class RoshamboApp {

        public static string StartRoshamboApp()
        {

            Console.Write("Would you like to play against Bababooie or LeftShark? (b/l): ");
            var playerSelection = Console.ReadLine();
            Validator.ValidatePlayerSelection(playerSelection);

            return playerSelection;

        }


    }
}
