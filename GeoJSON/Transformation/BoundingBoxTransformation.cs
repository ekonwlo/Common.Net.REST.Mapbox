using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Transformation;

namespace Common.Net.REST.Mapbox.GeoJSON.Transformation
{
    class BoundingBoxTransformation
        : IRestTransformation<MapboxBoundingBox, double[]>
    {
        public double[] Transform(MapboxBoundingBox input)
        {
            return new double[] { input.West, input.South, input.East, input.North };
        }

        public MapboxBoundingBox Revert(double[] input)
        {
            return new MapboxBoundingBox(input[0], input[1], input[2], input[3]);
        }
    }
}
