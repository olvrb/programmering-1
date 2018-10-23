using System;

namespace Slagsmålsspelet {
    public class PlayerStats {
        public int Hp { get; set; }
        public double StrengthMultiplier { get; }
        public PlayerStats(bool shouldRand, int hp = 100, double strengthMultiplier = 0) {
            Random rng = new Random();
            this.Hp = hp;
            if (shouldRand) {
                // https://stackoverflow.com/a/1064907/8611114
                this.StrengthMultiplier = rng.NextDouble() * (1 - 0.5) + 0.5;
            }
        }
    }
}