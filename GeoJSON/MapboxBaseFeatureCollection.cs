using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Maps.GeoJSON;

namespace Common.Net.REST.Mapbox.GeoJSON
{
    public abstract class MapboxBaseFeatureCollection
        : IFeatureCollection
    {
        public string Type { 
            get { return "FeatureCollection"; }
        }

        public IEnumerable<IFeature> Features
        {
            get
            {
                return (IEnumerable<IFeature>) InternalFeatures;
            }
            protected internal set
            {
                throw new NotImplementedException();
            }
        }

        protected internal abstract MapboxBaseFeature[] InternalFeatures { get; set; }
    }
}
