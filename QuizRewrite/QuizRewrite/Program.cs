using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Speech.Synthesis;


namespace QuizRewrite {
    internal static class Program {
        public static void Main(string[] args) {
            // fancy colors
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();

            // Initialize a new instance of the SpeechSynthesizer.  
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();

            // score, obv.
            int score = 0;
            // Create new questions
            QuizQuestion q1 = new QuizQuestion("What is Sweden's king's name?",
                                               new string[] {"Carl XVI Gustaf", "Folke Hubertus X", "Louis XVI", "Carl XI Gustav"},
                                               ConsoleKey.D1);
            QuizQuestion q2 = new QuizQuestion("When was the wheel invented?",
                                               new string[] {"5000 B.C.", "300 A.D.", "3500 B.C.", "300 B.C."}, ConsoleKey.D3);
            QuizQuestion q3 = new QuizQuestion("What does the ^ operator mean in programming?",
                                               new string[] {
                                                   "To the power of, like in math.", "It is the bitwise XOR operator.",
                                                   "It acts like the plus sign.", "It is a method which writes a string to the console."
                                               }, ConsoleKey.D2);
            QuizQuestion q4 = new QuizQuestion("What is the answer to everything", new string[] { "42", "69", "420", "1337" }, ConsoleKey.D1);
            QuizQuestion[] questions = {q1, q2, q3, q4}; // make a list so we can iterate through all questions easily
            Random rand    = new Random();
            List<QuizQuestion> randomizedQuizQuestions = questions.OrderBy(c => rand.Next()).ToList();
            
            // beautiful ascii art
            // creative name, isn't it?
            Console.WriteLine($@"
   ____        _      ____        _     
  / __ \      (_)    / __ \      (_)    
 | |  | |_   _ _ ___| |  | |_   _ _ ____
 | |  | | | | | |_  / |  | | | | | |_  /
 | |__| | |_| | |/ /| |__| | |_| | |/ / 
  \___\_\\__,_|_/___|\___\_\\__,_|_/___|
                                        
                                        ");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Press number keys to answer the questions.\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            foreach (QuizQuestion question in randomizedQuizQuestions) {
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

            if (questions.Length == score) {
                synth.Speak("Congratulations");
            }
            else {
                synth.Speak("You suck, you fucking piece of shit."); // 
            }

            Console.Clear();
            Console.WriteLine("Final score: " + score + "/" + questions.Length); // print final score \o/
            Console.ReadKey();
            
        }
    }
}
