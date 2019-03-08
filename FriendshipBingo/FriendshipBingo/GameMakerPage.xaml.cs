using System;
using System.Collections.Generic;
using Xamarin.Forms;
using FriendshipBingo.Models;

namespace FriendshipBingo
{
    public partial class GameMakerPage : ContentPage
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();

        public GameMakerPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (Name.Text != null && Players.Text != null)
            {
                var game = new Game
                {
                    Name = Name.Text,
                    Players = myDict.Count,
                    FactDict = myDict,
                };

                var boardPage = new Board(game);

                boardPage.BindingContext = game;

                Navigation.PushAsync(boardPage);
            }
            else
            {
                DisplayAlert("YO", "Make sure to fill out the game name and number of players.", "sure");
            }
        }

        void OnFactSubmit(object sender, System.EventArgs e)
        {
            if (PlayerName.Text != null && PlayerFact.Text != null)
            {
                myDict.Add(PlayerName.Text, PlayerFact.Text);
                PlayerName.Text = string.Empty;
                PlayerFact.Text = string.Empty;
            }
            else
            {
                DisplayAlert("YO", "Please fill out all fields.", "sure");
            }
        }

        private void DisplayAlert(string v)
        {
            throw new NotImplementedException();
        }
    }
}
