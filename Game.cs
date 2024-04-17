namespace GuessTheNumber{
    // Clase Game

     public class Game
    {
        private readonly int _secretNumber;
        private readonly Player _humanPlayer;
        private readonly Player _AIPlayer;

        public Game()
        {
            Random random = new Random();
            _secretNumber = random.Next(1, 101); // Generar un número aleatorio entre 1 y 100
            _humanPlayer = new HumanPlayer("Jugador Humano");
            _AIPlayer = new AIPlayer("Jugador AI");
        }

        public void InitializeGame()
        {
            PlayGame(_humanPlayer);
        }

        private void PlayGame(Player player)
        {
            int attempts = 0;

            while (true)
            {
                attempts++;
                player.MakeGuess();

                int lastGuess = player.GetLastGuess(); // Acceder al último intento del jugador

                if (lastGuess == _secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"\n🎉 ¡Felicidades, {player.Name}, has adivinado el número en {attempts} intentos! 🎉🎉🎉");
                    Console.ResetColor();
                    break;
                }
                else if (lastGuess < _secretNumber)
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

    internal class AIPlayer : Player
    {
        public AIPlayer(string name) : base(name)
        {
        }

        public override void MakeGuess()
        {
            throw new NotImplementedException();
        }
    }
}