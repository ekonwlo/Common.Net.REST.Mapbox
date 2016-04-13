using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Mapbox.GeoJSON.Coordinates
{
    internal class MapboxCoordinates3d
        : MapboxCoordinates
    {
       
        public MapboxLatLng[][] Value { get; internal set; }

        internal MapboxCoordinates3d() : base() { }
    }
}
