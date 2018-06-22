
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Xamarin.Forms;
using System;

namespace holamundo
{
    public class splash :ContentPage
    {

        Image splash1;
        public splash()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var sub = new AbsoluteLayout();
            splash1 = new Image
            {
                Source = "logo.png",
                WidthRequest = 200,
                HeightRequest=200
            };
            AbsoluteLayout.SetLayoutFlags(splash1,
            AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splash1,
             new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splash1);

            this.BackgroundColor = Color.FromHex("White");
            this.Content = sub;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await splash1.ScaleTo(1, 2000); //Time-consuming processes such as initialization
            await splash1.ScaleTo(0.9, 1500, Easing.Linear);
            await splash1.ScaleTo(150, 1200, Easing.Linear);
            Application.Current.MainPage = new NavigationPage(new TabMenu());    //After loading  MainPage it gets Navigated to our new Page
        }  
    }
}
