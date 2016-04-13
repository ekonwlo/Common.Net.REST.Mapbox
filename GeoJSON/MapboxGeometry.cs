using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Attributes;

namespace Common.Net.REST.Mapbox.GeoJSON
{
    using Attributes;
    using Transformation;
    using Maps.GeoJSON;
    using Coordinates;

    public sealed class MapboxGeometry
     : IGeometry, IGeometryCollection
    {
        private GeometryTypes _type;
        
        public GeometryTypes Type
        {
            get { return _type; }
            internal set { _type = value; }
        }
        
        public ICoordinates Coordinates
        {
            get { return (ICoordinates) InternalCoordinates; }
        }

        [RestContent("type")]
        internal string InternalType
        {
            get 
            {
                return _type.ToString();
            }
            set
            {
                _type = (GeometryTypes) Enum.Parse(typeof(GeometryTypes), value);
            }
        }

        [RestContent("coordinates", Mandatory = false)]
        [PropertyTransformation(typeof(CoordinatesTransformation), "CoordinatesTypeSelection")]
        internal MapboxCoordinates InternalCoordinates { get; set; }

        [RestContent("geometries", Mandatory = false)]
        internal MapboxGeometry[] InternalGeometries { get; set; }


        //internal protected abstract string InternalType { get; set; }
        //internal protected abstract MapboxCoordinates InternalCoordinates { get; set; }
        
        internal MapboxGeometry() { }
    }
}
