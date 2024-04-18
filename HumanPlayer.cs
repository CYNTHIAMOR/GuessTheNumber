using System;
using System.Collections.Generic;

namespace GuessTheNumber
{
    // Clase HumanPlayer que hereda de Player
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name) { }

        public override void MakeGuess()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Ingresa tu suposición: ");
            Console.ResetColor();
            if (!int.TryParse(Console.ReadLine(), out int guess))
            {   
                 Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("⚠️ Por favor, ingresa un número válido. ⚠️");
                 Console.ResetColor();
                return;
            }

            if (guess < 1 || guess > 100)
            {
                 Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Por favor ingresa un número entre 1 y 100.");
                Console.ResetColor();
                return;
            }

            Guesses.Add(guess);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($" 🎮tu propuesta es: {guess}🎮");
            Console.ResetColor();

        }
    }
}