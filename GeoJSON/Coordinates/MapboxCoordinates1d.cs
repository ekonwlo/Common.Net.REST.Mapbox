using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Mapbox.GeoJSON.Coordinates
{
    internal class MapboxCoordinates1d
        : MapboxCoordinates
    {

        public MapboxLatLng Value { get; internal set; }

        internal MapboxCoordinates1d() : base() { }

        internal MapboxCoordinates1d(MapboxLatLng value) : base()
        {
            Value = value;
        }

    }
}
