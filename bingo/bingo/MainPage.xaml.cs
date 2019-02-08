using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace bingo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Activated(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page());
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Success", "Event was handled", "Great!");
        }
    }
}
