using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using Common.Runtime.Serialization.Transformation;

namespace Common.Net.REST.Mapbox.v5.Geocode.Transformation
{
    class LatLngTransformation
        : IRestTransformation<MapboxLatLng, string>
    {
        private static readonly CultureInfo _cultureInfo;

        static LatLngTransformation()
        {
            _cultureInfo = new CultureInfo("en-US");
        }

        public string Transform(MapboxLatLng input)
        {
            return string.Format("{0},{1}", input.Longitude.ToString(_cultureInfo), input.Latitude.ToString(_cultureInfo));
        }

        public MapboxLatLng Revert(string input)
        {
            throw new NotImplementedException();
        }
    }
}
