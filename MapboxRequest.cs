using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Mapbox
{
    using Attributes;

    public abstract class MapboxRequest<T>
        : RestRequest<T> where T : MapboxResponse
    {

        [RestUrlParameter("access_token")]
        public string AccessToken { get; set; }
       
        protected internal MapboxRequest() : base() { }
    }
}
