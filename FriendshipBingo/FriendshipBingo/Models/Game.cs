using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FriendshipBingo.Models
{
    public class Game
    {
        public string Name;
        public int Players;
        public Dictionary<string, string> FactDict;

        public Game(string Name, int Players, Dictionary<string,string> fd)
        {
            this.Name = Name;
            this.Players = Players;
            this.FactDict = fd;
        }

    }
}
