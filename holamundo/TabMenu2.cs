using System;

using Xamarin.Forms;

namespace holamundo
{
    public class TabMenu : ContentPage
    {
        public TabMenu()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

