using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Validator
    {
        public static string GetUserName(string input)
        {
            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Name cannot be blank!");
                Console.Write("Enter name: ");
                input = Console.ReadLine();
            }

            return input;
        }

        public static string ValidatePlayerSelection(string input)
        {
            while (!input.Equals("b") || !input.Equals("l"))
            {
                Console.WriteLine("Invalid entry!");
                Console.Write("Would you like to play against Bababooie or LeftShark? (b/l): ");
                input = Console.ReadLine();
            }

            return input;
        }

        public static string ValidateRoshamboSelection(string input)
        {
            while (!input.Equals("r") || !input.Equals("p") || !input.Equals("s"))
            {
                Console.WriteLine("Invalid entry!");
                Console.Write("Rock, paper, or scissors? (r/p/s): ");
                input = Console.ReadLine();
            }

            return input;
        }
    }
}
