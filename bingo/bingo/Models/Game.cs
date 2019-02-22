using System;
namespace bingo.Models
{
    public class Game
    {
        public string gameName { get; set; }
        public int numPlayers { get; set; }
        public string[] facts { get; set; }
    }
}
