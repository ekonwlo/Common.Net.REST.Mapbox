using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Net.REST;
using Common.Net.REST.Attributes;

namespace Common.Net.REST.Mapbox.v1.Distance
{
    using Content;

    public class MapboxDistanceResponse
        : MapboxResponse
    {

        [RestContent("content")]
        public MapboxDistanceResponseContent Content { get; internal set; }
        
        protected internal MapboxDistanceResponse() : base() {}
    }
}
