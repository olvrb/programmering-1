using System;
using System.Collections.Generic;
using System.Linq;

namespace GetDivide {
    internal class Program {
        public static void Main(string[] args) {
            int input = 0;
            try {
                input = int.Parse(Console.ReadLine() ?? throw new Exception("Exited"));
            }
            catch (Exception) {
                Console.WriteLine("Please input a number.");
                // R E C U R S I O N
                Main(args);
            }
            
            // Sure I could do a reverse forloop but foreach is 👌.
            IEnumerable<int> nums = GetDivide(min: 0, max: input).Reverse();
            foreach (int num in nums) {
                Console.WriteLine(num);
            }   
        }

        private static IEnumerable<int> GetDivide(int max, int min = 0) {
            return Enumerable.Range(min, max).Where(i => i % 3 == 0).ToList();
        }
    }
}