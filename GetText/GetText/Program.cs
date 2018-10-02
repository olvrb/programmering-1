using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GetText {
    class Program {
        static void Main(string[] args) {
            string inp = GetText(1, 10);
        }

        static string GetText(int boundMin, int boundMax) {
            bool isValid = false;
            string tempIn = "";
            while (!isValid) {
                tempIn = Console.ReadLine();
                if ((tempIn.Length > boundMin && tempIn.Length < boundMax) && checkString(tempIn)) {
                    isValid = true;
                    break;
                }
                else {
                    isValid = false;
                }
            }
            return tempIn; // placeholder
        }

        static readonly string[] validStrings =  { "hejsan", "båt", "skola" };
        static readonly string[] InvalidStrings = { "ö", "skolinspektion", "hearthstone" };
        static bool checkString(string checkee) {
            if (Array.IndexOf(validStrings, checkee) > -1) {
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
