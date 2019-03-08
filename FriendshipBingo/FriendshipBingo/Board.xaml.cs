﻿using System;
using System.Collections.Generic;
using FriendshipBingo.Models;
using Xamarin.Forms;

namespace FriendshipBingo
{
    public partial class Board : ContentPage
    {
        List<int> randList = new List<int>();

        public Board(Game game)
        {
            Random rand = new Random();
            foreach (KeyValuePair<string, string> entry in game.FactDict)
            {
                int tileNum = rand.Next(24); // gets random number between 0 and 24
                randList.Add(tileNum);
                //string n = "control";
                //string tile = String.Concat(n, tileNum.ToString());           
            }
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var b = (Button)sender;

            if (b.BackgroundColor == Color.Green)
            {
                b.BackgroundColor = Color.DarkOrange;
            }
            else
            {
                b.BackgroundColor = Color.Green;
            }
            //Navigation.PushAsync(new QuestionPage());
        }

        // ** hide navigation **
        protected override void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
