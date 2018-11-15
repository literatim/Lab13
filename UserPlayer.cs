using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class UserPlayer : Player
    {
        public UserPlayer(string userName, string roshamboValue)
        {
            UserName = userName;
            RoshamboValue = roshamboValue;
        }

        public override static string GenerateRoshambo()
        {
            Console.Write("Rock, paper, or scissors? (r/p/s): ");
            var userInput = Console.ReadLine();
            Validator.ValidateRoshamboSelection(userInput);

            return userInput;

        }
    }
}
