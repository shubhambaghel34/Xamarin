using Xamarin.Forms;

namespace ProjectApp
{public class Tab1 : ContentPage
    {
        
        public Tab1()
        {
            Icon = "Play30.png";
            Padding = new Thickness(5, 5, 5, 5);
            Title = "Play";
           // BackgroundColor = Color.FromHex("#00796B");
            //Label lbl = new Label
            //{
            //    Text = "This is Tab1",
            //    TextColor = Color.Red,
            //    HorizontalOptions = LayoutOptions.StartAndExpand,
            //    VerticalOptions = LayoutOptions.Center
                
            //};

            //Content = new StackLayout
            //{
            //    Children =
            //    {
            //        lbl
            //    }
            //};

            


            this.Content = new TableView
            {
                Intent = TableIntent.Form,
               
                Root = new TableRoot("Table root")
            {
                new TableSection ("Table View")
                {
                    
                    new EntryCell
                    {
                        Label = "Name",
                        Placeholder = "Name",
                        Keyboard = Keyboard.Default
                    },
                    new SwitchCell { Text = "Switch"}
                 
        },


                new TableSection ("Form")
                {
                      //new TextCell {
                      //    Text = "TextCell",

                      //    Detail = "TextCell Det"

                      //},
                    new EntryCell
                    {
                        Label = "Mobile:",
                        Placeholder = "Enter the Mob No",
                        Keyboard = Keyboard.Telephone
                    },
                    new EntryCell
                    {
                        Label = "Email:",
                        Placeholder = "Enter email",
                        Keyboard = Keyboard.Email
                    },
                 
                  
                },
                



        }
    };



























        }

    }
}