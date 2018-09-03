using System;

namespace Frågesport {
    internal class Program {
        public static void Main(string[] args) {
            int score = 0;
            Q1 Q1 = new Q1();
            Q2 Q2 = new Q2();
            Q3 Q3 = new Q3();
            Console.WriteLine(Q1.Question + "                                                  Score: " + score);
            for (int i = 0; i < Q1.Answers.Length; i++) {
                Console.WriteLine((i + 1) + ") " + Q1.Answers[i]);
            }
            if (Console.ReadKey(true).Key == Q1.RightAnswerKey) {
                score++;
            }
            
            Console.Clear();
            
            Console.WriteLine(Q2.Question + "                                                  Score: " + score);
            for (int i = 0; i < Q2.Answers.Length; i++) {
                Console.WriteLine((i + 1) + ") " + Q2.Answers[i]);
            }
            if (Console.ReadKey(true).Key == Q2.RightAnswerKey) {
                score++;
            }
            
            Console.Clear();
            
            Console.WriteLine(Q3.Question + "                                                  Score: " + score);
            for (int i = 0; i < Q3.Answers.Length; i++) {
                Console.WriteLine((i + 1) + ") " + Q3.Answers[i]);
            }
            if (Console.ReadKey(true).Key == Q3.RightAnswerKey) {
                score++;
            }
            Console.Clear();
            Console.WriteLine("Final score: " + score);
            Console.ReadKey();
        }
    }
}