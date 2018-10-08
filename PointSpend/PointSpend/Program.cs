using System;

namespace PointSpend {
    internal class Program {
        public static void Main(string[] args) {
            // Declarations

            int input = 0;
            int pointToSpend = 12;
            bool keepGoing = true;
            
            // This is incredibly ugly.
            Console.WriteLine("Welcome! Please create your character.\nYou have 12to spend on Strength.\nHow many points would you like to spend on Strength? At least 1!");
            while (keepGoing) {
                try {
                    input = int.Parse(Console.ReadLine());
                    keepGoing = false;
                }
                catch (Exception e) {
                    keepGoing = true;
                    Console.WriteLine("Input was not in the correct format. Please input a number.");
                }

                if (!validate(input)) {
                    Console.WriteLine("Please enter a number between 1 and 12.");
                    keepGoing = true;
                }
            }

            pointToSpend -= input;
            Console.WriteLine($"All done!\n---------\nPoints left: {pointToSpend}");
        }

        static bool validate(int num) {
            return num > 0 && num < 13;
        }
    }
}