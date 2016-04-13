using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Mapbox.GeoJSON.Coordinates
{
    internal class MapboxCoordinates2d
        : MapboxCoordinates
    {

        public MapboxLatLng[] Value { get; internal set; }
        
        internal MapboxCoordinates2d() : base() { }

        internal MapboxCoordinates2d(MapboxLatLng[] value) : base() 
        {
            Value = value;
        }
    }
}
