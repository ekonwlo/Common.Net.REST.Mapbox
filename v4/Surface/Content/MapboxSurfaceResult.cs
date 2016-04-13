using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Net.REST.Attributes;

namespace Common.Net.REST.Mapbox.v4.Surface.Content
{
    using Transformation;

    public class MapboxSurfaceResult
    {

        [RestContent("id")]
        public int Id { get; internal set; }

        [RestContent("latlng")]
        public MapboxLatLng LatLng { get; internal set; }

        [RestContent("ele", Mandatory = false)]
        public double Elevation { get; internal set; }

        //[RestContent("fields")]
        //[PropertyTransformation(typeof(FieldsTransformation))]
        //public string[] Fields { get; set; }

        internal MapboxSurfaceResult() { }
    }
}
