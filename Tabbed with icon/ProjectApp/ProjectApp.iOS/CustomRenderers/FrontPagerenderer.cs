using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using ProjectApp;
using ProjectApp.iOS.CustomRenderers;

[assembly: ExportRenderer(typeof(FrontPage), typeof(FrontPagerenderer))]
namespace ProjectApp.iOS.CustomRenderers
{
   public class FrontPagerenderer: TabbedRenderer
    {
        public FrontPagerenderer()
        {
                
        }
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
        }
    }
}