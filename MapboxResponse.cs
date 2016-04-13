using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Net.REST;

namespace Common.Net.REST.Mapbox
{
    public abstract class MapboxResponse
        : RestResponse 
    {

        protected internal MapboxResponse() : base() { }
    }
}
