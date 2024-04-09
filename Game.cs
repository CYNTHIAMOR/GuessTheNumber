namespace GuessTheNumber;
using System;


    public class Game
    {
        public static void PlayGame()
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int attempts = 0;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nIngresa tu suposición: ");
                Console.ResetColor();
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string input = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            if (int.TryParse(input, out int guess))
                {
                    attempts++;

                    if (guess == secretNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"\n🎉 ¡Felicidades, has adivinado el número en {attempts} intentos! 🎉");
                        Console.ResetColor();
                        break;
                    }
                    else if (guess < secretNumber)
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
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Por favor, ingresa un número válido.");
                    Console.ResetColor();
                }
            }
        }
    }
