using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GetText {
    class Program {
        static void Main(string[] args) {
            List<string> str = new List<string>();
            for (int i = 0; i < 5; i++) {
                str.Add(GetText(2, 7));
            }
        }

        private static string GetText(int boundMin, int boundMax) {
            bool isValid = false;
            string tempIn = "";
            while (!isValid) {
                Console.Write($"enter text between {boundMin} and {boundMax} characters: ");
                tempIn = Console.ReadLine();
                if ((tempIn.Length > boundMin && tempIn.Length < boundMax) && checkString(tempIn)) {
                    isValid = true;
                }
                else {
                    isValid = false;
                }
            }
            return tempIn; // placeholder
        }

        private static readonly string[] ValidStrings =  { "hejsan", "båt", "skola" };
        private static readonly string[] InvalidStrings = { "ö", "skolinspektion", "hearthstone" };
        static bool checkString(string checkee) {
            // This is what's called spaghetti code.
            if (Array.IndexOf(ValidStrings, checkee) > -1) {
                return true;
            } 
            else if (Array.IndexOf(InvalidStrings, checkee) > -1) {
                return false;
            }
            else if (checkee.Length == 0) {
                return false;
            }
            else {
                return false;
            }

        }
    }
}
