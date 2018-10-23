using System;
using System.Threading;
namespace Slagsmålsspelet {
    class Program {
        static void Main(string[] args) {
            Console.Write("Name for player 1: ");
            Player player1 = new Player(Console.ReadLine());
            Console.Write("Name for player 2: ");
            Player player2 = new Player(Console.ReadLine());
            bool turn = true;
            while (true) {
                // declare random in loop so we get a new seed.
                int rand = new Random().Next(10, 30);
                if (turn) {
                    int dmg = player1.Damage(rand);
                    Console.WriteLine($"{player1 /* toString is called automatically here \o/ */} took {dmg} damage! ({((player1.Stats.Hp > 0) ? $"{player1.Stats.Hp}HP left" : "Dead")})");
                    if (!(player1.Stats.Hp > 0 && player2.Stats.Hp > 0)) break;
                }
                else {
                    int dmg = player2.Damage(rand);
                    Console.WriteLine($"{player2} took {dmg} damage! ({((player2.Stats.Hp > 0) ? $"{player2.Stats.Hp}HP left" : "Dead")})");
                    if (!(player1.Stats.Hp > 0 && player2.Stats.Hp > 0)) break;
                }
                turn = !turn;
                if (turn) {
                    Console.WriteLine("Press any key to proceed to next round...\n");
                    Console.ReadKey();
                    Console.Clear();
                }
                Thread.Sleep(1);
            }

            Console.WriteLine(player1.Stats.Hp > player2.Stats.Hp ? $"Player 2 lost! Player 1 has {player1.Stats.Hp} left" : $"Player 1 lost! Player 2 has {player2.Stats.Hp} left");
            Console.ReadKey();
        }
    }
}
