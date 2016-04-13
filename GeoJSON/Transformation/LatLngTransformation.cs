using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Transformation;

namespace Common.Net.REST.Mapbox.GeoJSON.Transformation
{
    class LatLngTransformation
        : IRestTransformation<MapboxLatLng, double[]>
    {
        public double[] Transform(MapboxLatLng input)
        {
            if (input == null)
                return null;

            return new double[] {input.Longitude, input.Latitude};
        }

        public MapboxLatLng Revert(double[] input)
        {
            return new MapboxLatLng(input[1], input[0]);
        }
    }
}
