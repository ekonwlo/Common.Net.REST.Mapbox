using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Attributes;
using Common.Net.REST.Mapbox.v1.Distance.Transformation;

namespace Common.Net.REST.Mapbox.v1.Distance.Content
{
    using Attributes;

    public class MapboxDistanceRequestContent
    {

        [RestContent("coordinates")]
        [PropertyTransformation(typeof(CoordinatesTransformation))]
        public MapboxLatLng[] Points { get; set; }

        internal MapboxDistanceRequestContent() { }

        public MapboxDistanceRequestContent(MapboxLatLng[] points) 
        {
            Points = points;
        }
    }
}
