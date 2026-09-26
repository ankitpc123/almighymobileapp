using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Matrimony.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:Xamarin.Forms.ExportRenderer(typeof(Entry),typeof(Matrimony.Droid.Renderer.EntryRenderer))]
namespace Matrimony.Droid.Renderer
{
   internal class EntryRenderer:Xamarin.Forms.Platform.Android.EntryRenderer
    {
        public EntryRenderer(Context context):base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if(e.NewElement !=null && Control !=null)
            {
                Control.Background = null;
            }
        }
    }
}