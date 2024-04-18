using System;
using System.Collections.Generic;

namespace GuessTheNumber
{
    // Clase abstracta Player
    public abstract class Player
    {
        public string Name { get; }
        public List<int> Guesses { get; } = new List<int>();

        protected Player(string name)
        {
            Name = name;
        }

        public abstract void MakeGuess();
    }
}
