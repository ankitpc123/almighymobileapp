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
using Matrimony.NewFolder;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.FastRenderers;
[assembly:Xamarin.Forms.ExportRenderer(typeof(AnimatedLabel),typeof(AnimatedLabelRenderer))]
namespace Matrimony.Droid.Renderer
{
   internal class AnimatedLabelRenderer: Xamarin.Forms.Platform.Android.LabelRenderer
    {
        public AnimatedLabelRenderer(Context context):base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if(e.NewElement != null && Control!=null)
            {
                var textView = Control as TextView;
                textView.Selected = true;

                //            android: singleLine = "true"
                //android: ellipsize = "marquee"
                //android: focusable = "true"
                //android: focusableInTouchMode = "true"
                textView.SetSingleLine(true); 
                textView.Ellipsize= (Android.Text.TextUtils.TruncateAt.Marquee);
                textView.SetHorizontallyScrolling(true);
                textView.SetMarqueeRepeatLimit(-1);
               // Control.HorizontalFadingEdgeEnabled = true;
            }
        }
    }
}