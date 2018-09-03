using System;

namespace Frågesport {
    public class Questions {
        public Q1 Q1;
        public Q2 Q2;
        public Q3 Q3;
        public Object[] QuestionArray { get; }

        public Questions() {
            this.QuestionArray = new object[] { this.Q1, this.Q2, this.Q3 }; // just so we can iterate through the classes easily
        }
    }
}