using System;
using Xamarin.Forms;

namespace bingo.Models
{
    public class Board : AbsoluteLayout
    {
        const int COLS = 9;
        const int ROWS = 9;
        const int BUGS = 10;

        Tile[,] tiles = new Tile[ROWS, COLS];

        public Board()
        {
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    Tile tile = new Tile(row, col);
                    this.Children.Add(tile);
                    tiles[row, col] = tile;
                }

            }
        }
    }
}
