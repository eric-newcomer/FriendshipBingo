using System;
using Xamarin.Forms;
namespace bingo.Models
{
    public class Tile : Frame
    {

        public Tile(int row, int column)
        {
            this.row = row;
            this.column = column;

            this.BackgroundColor = Color.Green;
            this.BorderColor = Color.Blue;
            this.Padding = 2;
        }
        public int row { get; set; }
        public int column { get; set; }
    }
}
