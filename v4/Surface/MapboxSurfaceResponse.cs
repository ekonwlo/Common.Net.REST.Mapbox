using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Net.REST.Attributes;

namespace Common.Net.REST.Mapbox.v4.Surface
{
    using Content;

    public class MapboxSurfaceResponse
        : MapboxResponse
    {

        [RestContent("content")]
        public MapboxSurfaceResponseContent Content { get; internal set; }

        private MapboxSurfaceResponse() : base() { }
 
    }
}
