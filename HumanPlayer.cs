namespace GuessTheNumber{

// Clase HumanPlayer que hereda de Player

    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name) { }

        public override void MakeGuess()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nIngresa tu suposición: ");
            Console.ResetColor();

            var input = Console.ReadLine();

            if (int.TryParse(input, out int guess))
            {
                LastGuess = guess;
                Predictions.Add(LastGuess);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Por favor, ingresa un número válido.");
                Console.ResetColor();
            }
        }
    }}

