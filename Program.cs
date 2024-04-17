using System;

namespace GuessTheNumber{
   public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido a GuessTheNumber! Por favor, ingresa tu nombre:");

            var humanName = Console.ReadLine();

            Console.WriteLine($"\n🎉 ¡Bienvenido a GuessTheNumberGame, {humanName}! 🎉");
            Console.WriteLine("\n🔍 Estoy pensando en un número entre 1 y 100. ¿Puedes adivinar cuál es? 🔍");

            Game game = new Game();
            game.InitializeGame();

            Console.WriteLine("\nGracias por jugar. ¡Hasta la próxima!");
        }
    }
}