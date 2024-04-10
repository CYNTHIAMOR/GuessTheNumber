using System;

namespace GuessTheNumber;

    // Clase Player que encapsula las características y acciones de un jugador
    public class Player
    {
        // Propiedad que almacena el nombre del jugador
        public string Name { get; }

        // Propiedad que almacena el último intento realizado por el jugador
        public int LastAttempt { get; private set; }

        // Constructor que inicializa el nombre y el último intento en cero
        public Player(string name)
        {
            Name = name;
            LastAttempt = 0;
        }

        // Método que hace la predicción solicitando un número por terminal
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
                LastAttempt = guess;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Por favor, ingresa un número válido.");
                Console.ResetColor();
            }
        }
    }