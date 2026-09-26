using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Xamarin.Forms.Color;

[assembly: Xamarin.Forms.ExportRenderer(typeof(EntryCell), typeof(Matrimony.Droid.Renderer.EntryCellRenderer))]
namespace Matrimony.Droid.Renderer
{
    internal class EntryCellRenderer : Xamarin.Forms.Platform.Android.EntryCellRenderer
    {
        Context context;
       
        public EntryCellRenderer()
        {
            this.context = Android.App.Application.Context; ;
        }
        protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
        {
            var cell = base.GetCellCore(item, convertView, parent, context) as EntryCellView;

            if (cell != null)
            {
                var textField = cell.EditText as TextView;

                textField.SetTextSize(Android.Util.ComplexUnitType.Dip, 16);
                Typeface f = Typeface.CreateFromAsset(this.context.Assets, "Roboto-Regular.ttf");
                textField.SetTypeface(f, TypefaceStyle.Normal);
                //textField.SetTextColor(Color.FromHex("#FF8800").ToAndroid()); 
                //cell.SetBackgroundColor(Color.FromHex("#FF8800").ToAndroid());


            }

            return cell;
        }
        //public EntryCellRenderer(Context context) : base(context)
        //{
        //}
        //protected override void OnElementChanged(ElementChangedEventArgs<EntryCell> e)
        //{
        //    base.OnElementChanged(e);
        //    if (e.NewElement != null && Control != null)
        //    {
        //        Control.Background = null;
        //    }
        //}
    }
}