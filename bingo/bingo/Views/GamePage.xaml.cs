using System;
using System.Collections.Generic;
using bingo.Models;
using Xamarin.Forms;

namespace bingo.Views
{
    public partial class GamePage : ContentPage
    {
        public GamePage()
        {
            InitializeComponent();
            Board board = new Board();

        }
    }
}
