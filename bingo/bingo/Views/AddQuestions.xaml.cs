using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace bingo
{
    public partial class AddQuestions : ContentPage
    {
        public AddQuestions()
        {
            InitializeComponent();
        }

        private async void ReadyToPlay(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Views.GamePage());
        }
    }
}
