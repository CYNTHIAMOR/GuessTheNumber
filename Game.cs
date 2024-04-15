using System;

namespace GuessTheNumber
{
    public class Game
    {
        private int _secretNumber;
        
        public Game()
        {
            Random random = new Random();
            _secretNumber = random.Next(1, 101); // Generar un número aleatorio entre 1 y 100
        }

        public void InitializeGame(Player player)
        {
            PlayGame(player);
        }

        private void PlayGame(Player player)
        {
            int attempts = 0;

            while (true)
            {
                attempts++;
                player.MakeGuess();

                if (player.GetLastGuess() == _secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"\n🎉 ¡Felicidades, {player.Name}, has adivinado el número en {attempts} intentos! 🎉");
                    Console.ResetColor();
                    break;
                }
                else if (player.GetLastGuess() < _secretNumber)
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
            }
        }
    }
}