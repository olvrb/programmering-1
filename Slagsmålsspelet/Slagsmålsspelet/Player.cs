using System;

namespace Slagsmålsspelet {
    public class Player {
        public PlayerStats Stats { get; }
        public string Name { get; }
        public Player(string name) {
            this.Stats = new PlayerStats(true);
            Console.WriteLine(this.Stats.Hp);
            this.Name = name;
        }

        public int Damage(int hitValue) {
            int dmg = RoundToInt((double) hitValue * this.Stats.StrengthMultiplier);
            this.Stats.Hp -= dmg;
            return dmg;
        }

        public override string ToString() {
            return this.Name;
        }
        
        // https://stackoverflow.com/a/52781757/8611114
        public static int RoundToInt(double f) { return (int)Math.Round(f); }
    }
}

