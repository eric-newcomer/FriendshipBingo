using System;
using System.Collections.Generic;

namespace Bingo.Models
{
    public class Game
    {
        public string GameName { get; set; }
        public int NumPlayers { get; set; }
        public List<string> Questions { get; set; }
    }
}
