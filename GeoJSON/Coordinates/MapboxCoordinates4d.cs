using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Mapbox.GeoJSON.Coordinates
{
    internal class MapboxCoordinates4d
        : MapboxCoordinates
    {
       
        public MapboxLatLng[][][][] Value { get; internal set; }

        internal MapboxCoordinates4d() : base() { }
    }
}
