using System;
using System.Speech.Synthesis;
using System.Threading;
namespace Slagsmålsspelet {
    class Program {
        static void Main(string[] args) {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.SelectVoiceByHints(VoiceGender.Male);
            synth.Rate = 2;
            Console.Write("Name for player 1: ");
            Player player1 = new Player(Console.ReadLine());
            Console.Write("Name for player 2: ");
            Player player2 = new Player(Console.ReadLine());
            bool turn = true;
            while (true) {
                // declare random in loop so we get a new seed. (Same seed doesn't happen because of the sleep at the end of the loop)
                int rand = new Random().Next(10, 30);
                if (turn) {
                    int dmg = player1.Damage(rand);
                    string _out = $"{player1 /* toString is called automatically here \o/ */} took {dmg} damage! ({((player1.Stats.Hp > 0) ? $"{player1.Stats.Hp}HP left" : "Dead")})";
                    Console.WriteLine(_out);
                    synth.Speak(_out);
                }
                else {
                    int dmg = player2.Damage(rand);
                    string _out = $"{player2} took {dmg} damage! ({((player2.Stats.Hp > 0) ? $"{player2.Stats.Hp}HP left" : "Dead")})";
                    Console.WriteLine(_out);
                    synth.Speak(_out);
                }
                if (!(player1.Stats.Hp > 0 && player2.Stats.Hp > 0)) break;
                turn = !turn;
                if (turn) {
                    Console.WriteLine("Press any key to proceed to next round...\n");
                    Console.ReadKey();
                    Console.Clear();
                }
                Thread.Sleep(1);
            }

            Console.WriteLine(player1.Stats.Hp > player2.Stats.Hp ? $"Player 2 lost! Player 1 has {player1.Stats.Hp} left" : $"Player 1 lost! Player 2 has {player2.Stats.Hp}hp left");
            Console.ReadKey();
        }
    }
}
