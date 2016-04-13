using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Attributes;

namespace Common.Net.REST.Mapbox.v5.Geocode
{
    using Attributes;
    using Transformation;

    [RestRequest("geocoding/v5/${dataset}/${coordinates}.json")]
    public class MapboxReverseGeocodeRequest
        : MapboxRequest<MapboxReverseGeocodeResponse>
    {
 
        [RestUrlParameter("${coordinates}")]
        [PropertyTransformation(typeof(LatLngTransformation))]
        public MapboxLatLng Coordinates { get; set; }

        [RestUrlParameter("types", Mandatory = false)]
        [PropertyTransformation(typeof(PlacesTypesTransformation))]
        public GeocodePlaceTypes PlacesTypes { get; set; }

        [RestUrlParameter("${dataset}")]
        public string Dataset { get; set; }

        private MapboxReverseGeocodeRequest() : base() { }
    
    }
}
