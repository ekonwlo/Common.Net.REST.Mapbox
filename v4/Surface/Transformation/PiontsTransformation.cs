using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Transformation;
using Common.Net.REST.Mapbox.v4.Surface.Content;

namespace Common.Net.REST.Mapbox.v4.Surface.Transformation
{
    public class PiontsTransformation
        : IRestTransformation<MapboxLatLng[], string>
    {
        public string Transform(MapboxLatLng[] points)
        {

            if (points.Length < 1)
                throw new ArgumentException("Points array must contain at least one element.", "points");

            double lat = 0, lng = 0;
            string polyline = string.Empty;

            for (int i = 0; i < points.Length; i++)
            {
                polyline += string.Format("{0}{1}", Encode(points[i].Latitude - lat), Encode(points[i].Longitude - lng));

                lat = points[i].Latitude;
                lng = points[i].Longitude;
            }
     
            return polyline;
        }

        public MapboxLatLng[] Revert(string input)
        {
            throw new NotImplementedException();
        }

        private static string Encode(double point)
        {
            
            int v1 = (int) Math.Round(point * 100000);

			uint v2 = uint.MaxValue;
			if (v1 < 0) {
				v2 = (~(uint)(Math.Abs(v1))) + 1;

			} else {
				v2 = (uint) v1;
                
			}

			v2 <<= 1;

			if (v1 < 0)
				v2 = ~v2;

			byte[] chunks = {
				(byte) (v2 << 27 >> 27),
				(byte) (v2 << 22 >> 27),
				(byte) (v2 << 17 >> 27),
				(byte) (v2 << 12 >> 27),
				(byte) (v2 << 7 >> 27),
				(byte) (v2 << 2 >> 27)
			};

			bool skip = false;
			byte take = 6;

			for (Int16 i = 4; i >= 0; i += -1) {
				if (chunks[i + 1] > 0 | skip) {
					skip = true;
					chunks[i] += 32;
				} else {
					take -= 1;
				}
			}

			chunks[0] += 63;
			chunks[1] += 63;
			chunks[2] += 63;
			chunks[3] += 63;
			chunks[4] += 63;
			chunks[5] += 63;

			return Encoding.ASCII.GetString(chunks, 0, take);
        }

    }
}
