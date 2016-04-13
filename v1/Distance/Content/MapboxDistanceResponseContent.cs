using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Net.REST.Attributes;

namespace Common.Net.REST.Mapbox.v1.Distance.Content
{
   
    public class MapboxDistanceResponseContent
    {

        [RestContent("durations")]
        public double?[][] Durations { get; internal set; }

        internal MapboxDistanceResponseContent() { }

    }
}
