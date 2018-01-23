using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ProjectApp
{
    public class Tab2 : ContentPage
    {
      
        public Tab2()
        {
         
            Icon = "Home30.png";
            Title = "Home";
            Padding = new Thickness(5, 5, 5, 5);
            BoxView bx = new BoxView()
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions=LayoutOptions.CenterAndExpand
            };
            ScrollView scrl = new ScrollView()
            {
                HorizontalOptions = LayoutOptions.Fill,
                Orientation = ScrollOrientation.Horizontal,
                Content = bx,


            };
           






        }
    
    }
}
    