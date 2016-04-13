using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Transformation;

namespace Common.Net.REST.Mapbox.v1.Distance.Transformation
{
    class CoordinatesTransformation
        : IRestTransformation<MapboxLatLng[], double[][]>
    {
        public double[][] Transform(MapboxLatLng[] input)
        {
            return (from point in input
                    select new double[] {point.Longitude, point.Latitude}).ToArray();
        }

        public MapboxLatLng[] Revert(double[][] input)
        {
            return (from point in input
                    select new MapboxLatLng(point[1], point[0])).ToArray();
        }
    }
}
