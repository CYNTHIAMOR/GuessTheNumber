using System.Numerics;
using System.Security;
using System;

namespace GuessTheNumber;
// Clase Game que gestiona la lógica del juego
    public class Game
    {
        // Propiedad que almacena un número aleatorio
        private readonly int _secretNumber;

        // Constructor que inicializa el número aleatorio
        public Game()
        {
            Random random = new Random();
            _secretNumber = random.Next(1, 101);
        }

        // Método para jugar el juego
        public void PlayGame(Player player)
        {
            int attempts = 0;

            while (true)
            {
                attempts++;
                player.MakeGuess();

                if (player.LastAttempt == _secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"\n🎉 ¡Felicidades, {player.Name}, has adivinado el número en {attempts} intentos! 🎉");
                    Console.ResetColor();
                    break;
                }
                else if (player.LastAttempt < _secretNumber)
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
