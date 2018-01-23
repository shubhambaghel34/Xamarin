using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Masternavigation
{
    public class Page : ContentPage
    {
        Button b1;
        Label l1;
        public Page()
        {
           l1= new Label
            {

                Text = "click here to navigate page ",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start
            };
            b1 = new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            Content = new StackLayout
            {
                Children = {
                    b1,
                    l1
                   
                  
                }
            };
            b1.Clicked += b1_Clicked;
        }

        private void b1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MasterPage());
        }
    }
}