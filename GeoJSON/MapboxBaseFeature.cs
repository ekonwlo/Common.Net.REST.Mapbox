using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Maps.GeoJSON;

namespace Common.Net.REST.Mapbox.GeoJSON
{
    public abstract class MapboxBaseFeature
        : IFeature
    {
        public string Type
        {
            get { return "Feature"; }
        }

        internal protected abstract string InternalType { get; set; } 

        public IGeometry Geometry
        {
            get
            {
                return (IGeometry) InternalGeometry;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        internal protected abstract MapboxGeometry InternalGeometry { get; internal set; }

        internal protected MapboxBaseFeature() { }
    }
}
