using System;
namespace bingo.Models
{
    public class Game
    {
        public string gameName { get; set; }
        public int numPlayers { get; set; }
        public int[] tileOptions { get; set; }
        public DateTime Date { get; set; }

    }
}
