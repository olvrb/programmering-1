using System;

namespace QuizRewrite {
    class QuizQuestion {
        public readonly string     Question;
        public readonly string[]   Answers;
        public readonly ConsoleKey RightAnswerKey;

        public QuizQuestion(string question, string[] answers, ConsoleKey rightAnswerKey) {
            this.Answers = new string[answers.Length - 1];
            this.Answers = answers;

            this.Question       = question;
            this.RightAnswerKey = rightAnswerKey;
        }
    }
}
