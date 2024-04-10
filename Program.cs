using System.Security;
namespace GuessTheNumber;
    // Clase Program que controla el flujo del programa
    public class Program
    {
        // Método principal del programa
        public static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido a GuessTheNumber! Por favor, ingresa tu nombre:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string name = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

        Console.WriteLine($"\n🎉 ¡Bienvenido a GuessTheNumberGame, {name}! 🎉");
            Console.WriteLine("\n🔍 Estoy pensando en un número entre 1 y 100. ¿Puedes adivinar cuál es? 🔍");

#pragma warning disable CS8604 // Possible null reference argument.
        Player player = new Player(name);
#pragma warning restore CS8604 // Possible null reference argument.
        Game game = new Game();
            game.PlayGame(player);

            Console.WriteLine("\nGracias por jugar. ¡Hasta la próxima!");
        }
    }
