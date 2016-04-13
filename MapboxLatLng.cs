using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Net.REST.Attributes;

namespace Common.Net.REST.Mapbox
{
    public class MapboxLatLng
    {

        [RestContent("lat")]
        public double Latitude { get;  set; }
       
        [RestContent("lng")]
        public double Longitude { get;  set; }

        internal MapboxLatLng() { }

        public MapboxLatLng(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public override string ToString()
        {
            return string.Format("Latitude = {0.000000}, Longitude = {1.000000}", Latitude, Longitude);
        }
    }
}
