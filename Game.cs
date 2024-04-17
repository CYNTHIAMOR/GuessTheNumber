using System;

namespace GuessTheNumber
{// Clase Game
    public class Game
    {
        private readonly int _secretNumber;
        private readonly Player _humanPlayer;
        private readonly Player _aiPlayer;

        public Game()
        {
            Random random = new Random();
            _secretNumber = random.Next(1, 101); // Generar un número aleatorio entre 1 y 100
            _humanPlayer = new HumanPlayer("Jugador Humano");
            _aiPlayer = new AIPlayer();
        }

        public void InitializeGame()
        {
            PlayGame(_humanPlayer, _aiPlayer);
        }

        private void PlayGame(Player humanPlayer, Player aiPlayer)
        {
            while (true)
            {
                humanPlayer.MakeGuess();
                int humanGuess = humanPlayer.Guesses[humanPlayer.Guesses.Count - 1];
                if (humanGuess == _secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"\n🎉 ¡Felicidades, {humanPlayer.Name}, has adivinado el número en {humanPlayer.Guesses.Count} intentos! 🎉🎉🎉");
                    Console.ResetColor();
                    break;
                }
                else if (humanGuess < _secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("El número secreto es mayor.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("El número secreto es menor.");
                    Console.ResetColor();
                }

                aiPlayer.MakeGuess();
                int aiGuess = aiPlayer.Guesses[aiPlayer.Guesses.Count - 1];
                if (aiGuess == _secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"\n🎉 ¡Felicidades, {aiPlayer.Name}, has adivinado el número en {aiPlayer.Guesses.Count} intentos! 🎉🎉🎉");
                    Console.ResetColor();
                    break;
                }
                else if (aiGuess < _secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("El número secreto es mayor para la IA.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("El número secreto es menor para la IA.");
                    Console.ResetColor();
                }
            }
        }
    }
}