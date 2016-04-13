using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using Common.Maps.GeoJSON;
using Common.Runtime.Serialization.Attributes;
using Common.Runtime.Serialization.Transformation;

namespace Common.Net.REST.Mapbox.GeoJSON.Transformation
{
    using GeoJSON.Coordinates;

    class CoordinatesTransformation
        : IRestTransformation<MapboxCoordinates, double[]>
        , IRestTransformation<MapboxCoordinates, double[][]>
        , IRestTransformation<MapboxCoordinates, double[][][]>
        , IRestTransformation<MapboxCoordinates, double[][][][]>
    {

        public TransofmationSelector.DynamicExpression<MapboxGeometry> CoordinatesTypeSelection
        {
            get
            {
                return (x) =>
                {
                    switch (x.Type)
                    {
                        case GeometryTypes.Point:
                            return typeof(double[]);
                        case GeometryTypes.MultiPoint:
                            return typeof(double[][]);
                        case GeometryTypes.LineString:
                            return typeof(double[][]);
                        case GeometryTypes.MultiLineString:
                            return typeof(double[][][]);
                        case GeometryTypes.Polygon:
                            return typeof(double[][][]);
                        case GeometryTypes.MultiPolygon:
                            return typeof(double[][][][]);
                        case GeometryTypes.GeometryCollection:
                            return null;
                            //return typeof(MapboxGeometry[]);

                    }
                    return null;
                };
            }
        }

        double[] IRestTransformation<MapboxCoordinates, double[]>.Transform(MapboxCoordinates input)
        {
            throw new NotImplementedException();
        }

        MapboxCoordinates IRestTransformation<MapboxCoordinates, double[]>.Revert(double[] input)
        {
            return new MapboxCoordinates1d( new MapboxLatLng(input[1], input[0]));
        }

        double[][] IRestTransformation<MapboxCoordinates, double[][]>.Transform(MapboxCoordinates input)
        {
            throw new NotImplementedException();
        }

        MapboxCoordinates IRestTransformation<MapboxCoordinates, double[][]>.Revert(double[][] input)
        {
            return new MapboxCoordinates2d((from latlng in input
                                            select new MapboxLatLng(latlng[1], latlng[0])).ToArray());
        }

        double[][][] IRestTransformation<MapboxCoordinates, double[][][]>.Transform(MapboxCoordinates input)
        {
            throw new NotImplementedException();
        }

        MapboxCoordinates IRestTransformation<MapboxCoordinates, double[][][]>.Revert(double[][][] input)
        {
            throw new NotImplementedException();
        }

        double[][][][] IRestTransformation<MapboxCoordinates, double[][][][]>.Transform(MapboxCoordinates input)
        {
            throw new NotImplementedException();
        }

        public MapboxCoordinates Revert(double[][][][] input)
        {
            throw new NotImplementedException();
        }
    }
}
