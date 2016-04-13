using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Transformation;

namespace Common.Net.REST.Mapbox.v5.Geocode.Transformation
{
    class PlacesTypesTransformation
        : IRestTransformation<GeocodePlaceTypes, string>
    {
        public string Transform(GeocodePlaceTypes input)
        {
            if (input < 0 || (int) input > 127)
                return null;

            List<string> places = new List<string>();

            if ((input & GeocodePlaceTypes.Country) > 0)
                places.Add("country");
            if ((input & GeocodePlaceTypes.Address) > 0)
                places.Add("address");
            if ((input & GeocodePlaceTypes.Neighborhood) > 0)
                places.Add("neighborhood");
            if ((input & GeocodePlaceTypes.Place) > 0)
                places.Add("place");
            if ((input & GeocodePlaceTypes.POI) > 0)
                places.Add("poi");
            if ((input & GeocodePlaceTypes.Postcode) > 0)
                places.Add("postcode");
            if ((input & GeocodePlaceTypes.Region) > 0)
                places.Add("region");

            return string.Join(",", places.ToArray());
        }

        public GeocodePlaceTypes Revert(string input)
        {
            throw new NotImplementedException();
        }
    }
}
