using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Attributes;

namespace Common.Net.REST.Mapbox.v5.Geocode.Content
{
    using Attributes;
    using GeoJSON;
    using GeoJSON.Transformation;

    public class MapboxFeature
        : MapboxBaseFeature
    {

        [RestContent("id")]
        public string Id { get; set; }

        [RestContent("text")]
        public string Text { get; set; }

        [RestContent("place_name")]
        public string PlaceName { get; set; }

        [RestContent("relevance")]
        public double Relevance { get; set; }

        [RestContent("context")]
        public MapboxContext[] Contexts { get; set; }

        [RestContent("address")]
        public string Address { get; set; }
       
        [RestContent("center")]
        [PropertyTransformation(typeof(LatLngTransformation))]
        public MapboxLatLng Center { get; set; }

        [RestContent("bbox")]
        [PropertyTransformation(typeof(BoundingBoxTransformation))]
        public MapboxBoundingBox Bbox { get; set; }

        [RestContent("type")]
        protected internal override string InternalType { get; set; }

        [RestContent("geometry")]
        protected internal override MapboxGeometry InternalGeometry { get; internal set; }
       
        internal MapboxFeature() : base() { }
    }
}
