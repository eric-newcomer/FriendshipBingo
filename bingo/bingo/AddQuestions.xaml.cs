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
            var layout = new StackLayout { Padding = new Thickness(5, 10), BackgroundColor = Color.White };
            this.Content = layout;
            var editor = new Editor { BackgroundColor = Color.White, HeightRequest = 500 };
            layout.Children.Add(editor);
        }
    }
}
