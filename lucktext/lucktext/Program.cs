﻿using System;

namespace lucktext {
    internal static class Program {
        public static void Main(string[] args) {
            string sentence = "The quick brown <name> jumps over the <adjective1> <adjective2> dog.";
            Console.Write(sentence + "\nInput a name: ");
            string name = Console.ReadLine();
            Console.Write("Input an adjevtive: ");
            string adj = Console.ReadLine();
            Console.Write("Input another adjevtive: ");
            string adj2 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(FormatString(sentence, name, adj, adj2));
            Console.ReadKey();
        }

        private static string FormatString(string toBeFormatted, string name, string adj, string adj2) {
            // this is bad code
            return toBeFormatted
                   .Replace("<name>", name)
                   .Replace("<adjective1>", adj)
                   .Replace("<adjective2>", adj2);
        }
    }
}