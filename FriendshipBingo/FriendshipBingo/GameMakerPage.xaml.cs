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
            Navigation.PushAsync(new Board());
        }

        void OnFactSubmit(object sender, System.EventArgs e)
        {
            if (PlayerName.Text != null && PlayerFact.Text != null)
            {
                myDict.Add(PlayerName.Text, PlayerFact.Text);
                PlayerName.Text = string.Empty;
                PlayerFact.Text = string.Empty;
            }
        }
    }
}
