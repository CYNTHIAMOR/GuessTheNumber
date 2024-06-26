using System;

namespace GuessTheNumber
{
    // Clase AIPlayer que hereda de Player
    public class AIPlayer : Player
    {
        private readonly Random _random = new Random();

        public AIPlayer() : base("IA") { }

        public override void MakeGuess()
        {
            int guess = _random.Next(1, 101);
            Guesses.Add(guess);
            Console.WriteLine($"🤖 IA propuso 🤖: {guess}");
        }
    }
}
