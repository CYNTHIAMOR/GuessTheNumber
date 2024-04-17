using System;
using System.Collections.Generic;

namespace GuessTheNumber{
// Clase HumanPlayer que hereda de Player
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name) { }

        public override void MakeGuess()
        {
            Console.Write("Ingresa tu suposición: ");
            if (!int.TryParse(Console.ReadLine(), out int guess))
            {
                Console.WriteLine("Por favor ingresa un número válido.");
                return;
            }

            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("Por favor ingresa un número entre 1 y 100.");
                return;
            }

            Guesses.Add(guess);
            Console.WriteLine($"Has adivinado: {guess}");
        }
    }
}
