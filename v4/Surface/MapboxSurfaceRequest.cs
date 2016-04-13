using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Net.REST;
using Common.Runtime.Serialization.Attributes;
using Common.Net.REST.Mapbox.v4.Surface.Content;
using Common.Net.REST.Mapbox.v4.Surface.Transformation;

namespace Common.Net.REST.Mapbox.v4.Surface
{
    using Attributes;

    [RestRequest("v4/surface/${mapid}.json")]
    public class MapboxSurfaceRequest
        : MapboxRequest<MapboxSurfaceResponse>
    {

        [RestUrlParameter("${mapid}")]
        public string MapId { get; set; }
        
        [RestUrlParameter("layer")]
        public string Layer { get; set; }

        [RestUrlParameter("fields")]
        [PropertyTransformation(typeof(FieldsTransformation))]
        public string[] Fields { get; set; }

        [RestUrlParameter("z", Mandatory = false)]
        public string Zoom { get; set; }

        [RestUrlParameter("encoded_polyline")]
        [PropertyTransformation(typeof (PiontsTransformation))]
        public MapboxLatLng[] Points { get; set; }

        [RestUrlParameter("interpolate", Mandatory = false)]
        public bool Interpolate { get; set; }

        [RestUrlParameter("geojson", Mandatory = false)]
        public bool Geojson { get; set; }

        private MapboxSurfaceRequest() : base() { }
    
    }
}
