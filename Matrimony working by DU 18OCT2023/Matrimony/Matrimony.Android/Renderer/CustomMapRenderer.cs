using System;
using System.Collections.Generic;
using Android.Content;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.Views;
using Matrimony.Droid.Renderer;
using Matrimony.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Maps.Android;


[assembly: ExportRenderer(typeof(CustomMap), typeof(CustomMapRenderer))]
namespace Matrimony.Droid.Renderer
{
    public class CustomMapRenderer : MapRenderer
    {
        List<CustomPin> customPins;

        public CustomMapRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(Xamarin.Forms.Platform.Android.ElementChangedEventArgs<Map> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            { }

            if (e.NewElement != null)
            {
                var formsMap = (CustomMap)e.NewElement;
                customPins = formsMap.CustomPins;
            }
        }

        protected override MarkerOptions CreateMarker(Pin pin)
        {
            CustomPin customPin = (CustomPin)pin;
            var marker = new MarkerOptions();
            marker.SetPosition(new LatLng(pin.Position.Latitude, pin.Position.Longitude));
            marker.SetTitle(pin.Label);
            marker.SetSnippet(pin.Address);

            if (customPin.gender.ToLower().Equals("female"))
                marker.SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.girlpin));
            else if (customPin.gender.ToLower().Equals("male"))
                marker.SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.boypin));
            else 
                marker.SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.Marker));
            return marker;
        }

        protected override void OnMapReady(GoogleMap map)
        {
            base.OnMapReady(map);
        }

    }
}
