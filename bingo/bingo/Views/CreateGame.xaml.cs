using System;
using System.Collections.Generic;
using bingo.Models;
using bingo.ViewModels;
using Xamarin.Forms;

namespace bingo.Views
{
    public partial class CreateGame : ContentPage
    {
        public CreateGame()
        {
            InitializeComponent();
            BindingContext = new CreateGameViewModel();
        }

        private async void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddQuestions());
        }
    }
}
