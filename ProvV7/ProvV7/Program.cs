using System;
using System.Collections.Generic;

namespace ProvV7 {
    internal static class Program {
        public static void Main(string[] args) {
            bool studentNumberIsValid = false;

            // An array could potentially be used here if initialized after asking for amount of students, but a list is more appropriate.
            List<string> studentNames = new List<string>();
            int          students     = 0;

            // Keep asking for input as long as it's invalid.
            while (!studentNumberIsValid) {
                Console.Write("Enter a number of students to store: ");
                if (int.TryParse(Console.ReadLine(), out students)) {
                    studentNumberIsValid = true;
                }

                if (students <= 0) {
                    studentNumberIsValid = false;
                    Console.Clear();
                    Console.WriteLine("Number of students cannot be under 0.");
                }
            }


            for (int i = 0; i < students; i++) {
                Console.WriteLine($"Getting name for student #{i}.");
                studentNames.Add(GetName(false));
            }


            // Finish up by printing the random two students.
            Console.WriteLine($"Two random student names:\n{GetRandomStudent(studentNames)}\n{GetRandomStudent(studentNames)}");

            Console.ReadKey();
        }

        // Avoid getting the same seed if method is called at the same time.
        private static readonly Random Rand = new Random();

        private static string GetRandomStudent(IReadOnlyList<string> studentNames) {
            // Access a random index...
            return studentNames[Rand.Next(0, studentNames.Count)];
        }

        private static string GetName(bool isNameFirst) {
            bool   nameIsValid = false;
            string name        = "";
            string surname     = "";
            while (!nameIsValid) {
                // Ask for name.
                Console.Write("Please enter name: ");
                name = Console.ReadLine().Trim();

                // Then surname...
                Console.Write("Please enter surname: ");
                surname = Console.ReadLine().Trim();

                // Make sure name meets requirements.
                if (NameIsValid(name) && NameIsValid(surname)) nameIsValid = true;
                // Otherwise show an error message.
                else {
                    Console.Clear();
                    Console.WriteLine("Invalid names, please try again.\n");
                }
            }

            // Ternary statements ftw.
            return isNameFirst ? $"{name} {surname}" : $"{surname} {name}";
        }

        private static bool NameIsValid(string name) {
            return name.Length > 0 && name.Length <= 64;
        }
    }
}