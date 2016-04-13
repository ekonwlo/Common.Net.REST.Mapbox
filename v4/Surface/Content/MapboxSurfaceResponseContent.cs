using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Net.REST.Attributes;

namespace Common.Net.REST.Mapbox.v4.Surface.Content
{
    public class MapboxSurfaceResponseContent
    {

        [RestContent("attribution")]
        public string Attribution { get; internal set; }

        [RestContent("results")]
        public MapboxSurfaceResult[] Resutls { get; internal set; }
        
        internal MapboxSurfaceResponseContent() { }
    }
}
