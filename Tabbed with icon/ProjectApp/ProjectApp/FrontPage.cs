using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectApp
{
  public  class FrontPage:TabbedPage
    {
       
     public ToolbarItem tlbr;
     
        public FrontPage()
        {
          
            //var tlbr = new ToolbarItem
            //{
            //    Text = "Add",
            //    Icon = "BulletedList30.png",
            //    Priority = 0,
            //    Order = ToolbarItemOrder.Secondary
            //};
            //Device.BeginInvokeOnMainThread(() => this.ToolbarItems.Add(tlbr));
            



            //ToolbarItems.Add(new ToolbarItem
            //  ("First", "Info30.png", () => { Device.BeginInvokeOnMainThread(() => { Title = "First"; }); },
            //  ToolbarItemOrder.Secondary, 0));
            Children.Add(new Tab1() );
            Children.Add(new Tab2());
            Children.Add(new Tab3() );
           
            Title = "Page";
           BarBackgroundColor = Color.FromHex("#00796B");
         //  BarTextColor = Color.FromHex("#bc4b4b");
            // BarBackgroundColor=Color.FromHex("#bc4b4b");
         





        }

        
    }
}
