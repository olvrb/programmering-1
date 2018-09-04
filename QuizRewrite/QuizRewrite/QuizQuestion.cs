using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizRewrite {
    class QuizQuestion {
        public readonly string     Question;
        public readonly string[]   Answers;
        public readonly ConsoleKey RightAnswerKey;

        public QuizQuestion(string Question, string[] Answers, ConsoleKey RightAnswerKey) {
            this.Answers = new string[Answers.Length - 1];
            this.Answers = Answers;

            this.Question       = Question;
            this.RightAnswerKey = RightAnswerKey;
        }
    }
}
