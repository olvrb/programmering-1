using System;

namespace prog1_prov_grunderna {
    class Program {
        static void Main(string[] args) {
            // start out with declarations
            string username;
            int level;

            Console.WriteLine("Please choose a username (3-32 characters).");
            while (true) {
                username = Console.ReadLine();
                // validate username, short and simple
                if (isUsernameValid(username)) break;
                Console.WriteLine("Invalid username.");
            }

            Console.WriteLine("Choose level (1-20).");
            while (true) {
                // i don't like tryparse but it's a lot shorter
                bool didParse = int.TryParse(Console.ReadLine(), out level);
                // validate the input and make sure the parsing went well
                if (didParse && validateLevel(level)) break;
                Console.WriteLine("Input a valid level.");
            }

            // finalize with telling the user their selection
            Console.WriteLine($"Starting at level {level} with username {username}");
            Console.ReadKey();
        }

        static bool isUsernameValid(string username) {
            int amountOfLetters = 0;

            // iterate through all chars and check if the char is a letter (i was gonna use regex but am too lazy to write one, and some test say it's a lot slower)
            foreach (char c in username) {
                if (Char.IsLetter(c)) amountOfLetters++;
            }

            // strictly between 3 and 32, since the example program does that.
            return username.Length > 3 && username.Length < 32 && amountOfLetters != 0;
        }

        static bool validateLevel(int level) {
            // i could use <=/>= but that's uglier imo.
            return level > 0 && level < 21;
        }
    }
}
