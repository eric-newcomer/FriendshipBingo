using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FriendshipBingo
{
    public partial class Board : ContentPage
    {
        public Board()
        {
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
        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    NavigationPage.SetHasNavigationBar(this, false);
        //}
    }
}
