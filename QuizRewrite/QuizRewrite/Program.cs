﻿using System;

namespace QuizRewrite {
    internal static class Program {
        public static void Main(string[] args) {
            // score, obv.
            int score = 0;
            // Create new questions

            QuizQuestion Q1 = new QuizQuestion("What is Sweden's king's name?",
                                               new string[] {"Carl XVI Gustaf", "Folke Hubertus X", "Louis XVI", "Carl XI Gustav"},
                                               ConsoleKey.D1);
            QuizQuestion Q2 = new QuizQuestion("When was the wheel invented?",
                                               new string[] {"5000 B.C.", "300 A.D.", "3500 B.C.", "300 B.C."}, ConsoleKey.D3);
            QuizQuestion Q3 = new QuizQuestion("What does the ^ operator mean in programming?",
                                               new string[] {
                                                   "To the power of, like in math.", "It is the bitwise XOR operator.",
                                                   "It acts like the plus sign.", "It is a method which writes a string to the console."
                                               }, ConsoleKey.D2);
            QuizQuestion[] Questions = new QuizQuestion[] {Q1, Q2, Q3}; // make a list so we can iterate through all questions easily
            foreach (QuizQuestion question in Questions) {
                Console.WriteLine(question.Question + "                                                  Score: " +
                                  score);                           // start off with printing the question
                for (int i = 0; i < question.Answers.Length; i++) { //print all answers
                    Console.WriteLine((i + 1) + ") " + question.Answers[i]);
                }


                if (Console.ReadKey(true).Key == question.RightAnswerKey) { // yes
                    Console.WriteLine("Right answer!");
                    score++;
                }

                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine("Final score: " + score + "/" + Questions.Length); // print final score \o/
            Console.ReadKey();
        }
    }
}