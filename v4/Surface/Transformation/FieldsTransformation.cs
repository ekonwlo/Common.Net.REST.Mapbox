using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Transformation;

namespace Common.Net.REST.Mapbox.v4.Surface.Transformation
{
    class FieldsTransformation
        : IRestTransformation<string[], string>
    {
        public string Transform(string[] input)
        {
            return string.Join(",", input);
        }

        public string[] Revert(string input)
        {
            return input.Split(',');
        }
    }
}
