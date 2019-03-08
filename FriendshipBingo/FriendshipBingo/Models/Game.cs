using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FriendshipBingo.Models
{
    public class Game
    {
        public string Name { get; set; }
        public int Players { get; set; }
        public Dictionary<string, string> FactDict { get; set; }


    }
}
