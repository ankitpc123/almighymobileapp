using System;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Matrimony.Helper
{
    public class Constant
    {
        public static double userLocationLat = 0.0;
        public static double userLocationLng = 0.0;
        public static double currentLat = 23.2252322;
        public static double currentLng = 77.4849719;
    }


    public class Helper
    {
        public async static Task<bool> GetLocationUsingAddress(string address)
        {
            try
            {
                //address = "Microsoft Building 25 Redmond WA USA";
                var locations = await Geocoding.GetLocationsAsync(address);
                var location = locations?.FirstOrDefault();
                if (location != null)
                {
                    Constant.userLocationLat = location.Latitude;
                    Constant.userLocationLng = location.Longitude;
                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                    return true;
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature not supported on device
            }
            catch (Exception ex)
            {
                // Handle exception that may have occurred in geocoding
            }
            return false;
        }

        /// <summary>
        /// Calculate distance between two coordinates using Haversine formula
        /// </summary>
        private static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            // Earth radius in kilometers
            const double earthRadius = 6371;

            // Convert degrees to radians
            var dLat = ToRadians(lat2 - lat1);
            var dLon = ToRadians(lon2 - lon1);

            // Haversine formula
            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return earthRadius * c; // Distance in kilometers
        }

        private static double ToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }
    }
}
