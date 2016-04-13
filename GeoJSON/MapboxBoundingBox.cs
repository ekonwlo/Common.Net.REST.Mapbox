using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Mapbox.GeoJSON
{
    public class MapboxBoundingBox
    {
        private MapboxLatLng _southWest;
        private MapboxLatLng _northEast;

        public double West
        {
            get
            {
                return _southWest.Latitude;
            }
            set
            {
                _southWest.Latitude = value;
            }
        }

        public double East
        {
            get
            {
                return _northEast.Latitude;
            }
            set
            {
                _northEast.Latitude = value;
            }
        }

        public double North
        {
            get
            {
                return _northEast.Longitude;
            }
            set
            {
                _northEast.Longitude = value;
            }
        }

        public double South
        {
            get
            {
                return _southWest.Longitude;
            }
            set
            {
                _southWest.Longitude = value;
            }
        }

        public MapboxBoundingBox(double west, double south, double east, double north)
        {
            _southWest = new MapboxLatLng(west, south);
            _northEast = new MapboxLatLng(east, north);
        }

        public override string ToString()
        {
            return string.Format("West = {0.000000}, South = {1.000000}, East = {2.000000}, North = {3.000000}", West, South, East, North);
        }
    }
}
