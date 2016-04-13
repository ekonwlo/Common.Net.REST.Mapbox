using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Mapbox.v5.Geocode.Content
{
    using Attributes;
    using Transformation;
    using GeoJSON;

    public class MapboxFeatureCollection
        : MapboxBaseFeatureCollection
    {
        [RestContent("type")]
        public string Type { get; internal set; }

        [RestContent("query")]
        public double[] Query { get; internal set; }

        [RestContent("features")]
        internal protected new MapboxFeature[] Features { get; internal set; }

        internal protected override MapboxBaseFeature[] InternalFeatures
        {
            get
            {
                return this.Features;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        [RestContent("attribution")]
        public string Attribution { get; internal set; }

        internal  MapboxFeatureCollection() : base() { }
    }
}
