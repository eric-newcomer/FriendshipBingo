using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using bingo.Models;
using bingo.Views;
using Xamarin.Forms;

namespace bingo.ViewModels
{
    public class CreateGameViewModel : INotifyPropertyChanged
    {
        public string gameName { get; set; }
        public int numPlayers { get; set; }
        public string[] facts { get; set; }
        

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public CreateGameViewModel()
        {

        }

        public Command PushPageCommand { get; }

    }
}
