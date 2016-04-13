using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Net.REST.Attributes;


namespace Common.Net.REST.Mapbox.v5.Geocode
{
    using Content;

    public class MapboxReverseGeocodeResponse
        : MapboxResponse
    {

        [RestContent("content")]
        public MapboxFeatureCollection Content { get; internal set; }

        private MapboxReverseGeocodeResponse() : base() { }
 
    }
}
