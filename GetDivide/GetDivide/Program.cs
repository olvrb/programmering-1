using System;
using System.Collections.Generic;
using System.Linq;

namespace GetDivide {
    internal class Program {
        public static void Main(string[] args) {
            //Spinner spin = new Spinner(0,0);
            int input = 0;
            try {
                input = int.Parse(Console.ReadLine());
            }
            catch (Exception e) {
                Console.WriteLine("Please input a number.");
                // R E C U R S I O N
                Main(args);
            }
            
            // Sure I could do a reverse forloop but foreach is 👌.
            IEnumerable<int> nums = GetDivide(input).Reverse();
            foreach (int num in nums) {
                Console.WriteLine(num);
            }   
        }

        static IEnumerable<int> GetDivide(int max) {
            List<int> nums = new List<int>();
            for (int i = 0; i < max; i++) {
                if (i % 3 == 0) {
                    nums.Add(i);
                }
            }

            return nums;
        }
    }
}