using Xamarin.Forms;

namespace ProjectApp
{
    public class Tab3 : ContentPage
    {
        public Tab3()
        {
            StackLayout styl = new StackLayout();
            Icon = "Info30.png";
            Title = "Info";
           Padding = new Thickness(5, 5, 5, 5);
            
            ScrollView sc = new ScrollView()
            {
                IsClippedToBounds = true,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content =new Label()
              {
                  Text= @"sgfsdngjkdndfmzklnvlk.kkkfjdfhjldfkhdfhdfhfhfhfdhdfldflhflhdfhgkdfhkfdgglhhlnhjngknlhglnlhl",

                 
                  HorizontalOptions=LayoutOptions.Center,
                  VerticalOptions=LayoutOptions.Center
              },
                
            };
            //  BackgroundColor = Color.DarkOliveGreen;
            // var label = new Label();
            styl = new StackLayout
            {
                Children =
             {
                    sc

             }
            };
            Content = styl;
            
          
        }
    }
}