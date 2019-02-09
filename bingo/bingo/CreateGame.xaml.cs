using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace bingo
{
    public partial class CreateGame : ContentPage
    {
        public CreateGame()
        {
            InitializeComponent();
        }

        private async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
