using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;
using ProjectApp;
using ProjectApp.Droid.CustomRenderers;
using Android.Graphics.Drawables;
using Android.Graphics;
using static Android.Support.V7.App.ActionBar;
using static Android.Support.Design.Widget.TabLayout;
using static Android.App.ActionBar;
using Android;

[assembly: ExportRenderer(typeof(FrontPage), typeof(FrontPagerenderer))]
namespace ProjectApp.Droid.CustomRenderers
{
  public  class FrontPagerenderer: TabbedPageRenderer
    {
     
        public FrontPagerenderer()
        {
            
        }
        //protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        //{
        //    base.OnElementChanged(e);
          

        //    if (Element != null)
        //    {
              
        //    }
        //}
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }
      


      
    }
}