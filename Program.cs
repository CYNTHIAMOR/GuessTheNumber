namespace GuessTheNumber;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido a GuessTheNumber! Por favor, ingresa tu nombre:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string name = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

        Console.WriteLine($"\n🎉 ¡Bienvenido a GuessTheNumberGame, {name}! 🎉");
            Console.WriteLine("\n🔍 Estoy pensando en un número entre 1 y 100. ¿Puedes adivinar cuál es? 🔍");

            Game.PlayGame();

            Console.WriteLine("\nGracias por jugar. ¡Hasta la próxima!");
        }
    }

/*{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}*/
