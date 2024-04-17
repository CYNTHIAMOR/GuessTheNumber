using System;
using System.Collections.Generic;

namespace GuessTheNumber
{
    // Clase abstracta Player
    public abstract class Player
    {
        public string Name { get; }
        public List<int> Guesses { get; } = new List<int>();

        protected Player(string name)
        {
            Name = name;
        }

        public abstract void MakeGuess();
    }

    // Clase AIPlayer que hereda de Player
    public class AIPlayer : Player
    {
        private readonly Random _random = new Random();

        public AIPlayer() : base("IA") { }

        public override void MakeGuess()
        {
            int guess = _random.Next(1, 101);
            Guesses.Add(guess);
            Console.WriteLine($"🤖 IA ha adivinado: {guess}");
        }
    }
}

/*using System;

namespace GuessTheNumber
{
public class Player
{
    public string Name { get; }

    private int _lastGuess;

    public Player(string name)
    {
        Name = name;
        _lastGuess = -1; // Inicializar con un valor que no sea válido
    }

    public void MakeGuess()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\nIngresa tu suposición: ");
        Console.ResetColor();

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string input = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

        if (int.TryParse(input, out int guess))
        {
            _lastGuess = guess;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Por favor, ingresa un número válido.");
            Console.ResetColor();
        }
    }

    public int GetLastGuess()
    {
        return _lastGuess;
    }
}
} */