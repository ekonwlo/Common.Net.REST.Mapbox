using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Mapbox.v5.Geocode.Content
{
    using Attributes;

    public class MapboxContext
    {

        [RestContent("id")]
        public string Id { get; set; }

        [RestContent("text")]
        public string Text { get; set; }

        internal MapboxContext() { }
    }
}
