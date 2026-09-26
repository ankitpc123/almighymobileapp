using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportRenderer(typeof(TableView), typeof(Matrimony.Droid.Renderer.TableViewRenderer))]
namespace Matrimony.Droid.Renderer
{
   public class TableViewRenderer :Xamarin.Forms.Platform.Android.TableViewRenderer
    {
        public TableViewRenderer(Context   context):base(context)
        {

        }
        private bool FirstElementAdded = false;
        protected override void OnElementChanged(ElementChangedEventArgs<TableView> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
                return;
            var listView = Control as global::Android.Widget.ListView;
            listView.Divider = new ColorDrawable(Android.Graphics.Color.Transparent);
            listView.DividerHeight = 0;

            // var zoControl = (TableView)e.NewElement;
            // var listView = Control as global::Android.Widget.ListView;
            //// if (zoControl.SeperatorVisible == SeparatorVisibility.None)
            // {
            //     listView.Divider.SetTint(Color.Transparent.GetHashCode());
            //     listView.Divider.SetVisible(false, false);
            //     //listView.SetHeaderDividersEnabled(false);
            // }
            //listView.ChildViewAdded += (sender, args) => {

            //    if (!FirstElementAdded)
            //    {
            //        args.Child.Visibility = ViewStates.Gone;
            //        FirstElementAdded = true;

            //    }

            //};

        }
    }
}
