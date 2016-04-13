using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Net.REST.Attributes;

namespace Common.Net.REST.Mapbox.v1.Distance
{
    using Content;
    using Transformation;

    [RestContentType("application/json", "charset=utf-8")]
    [RestRequest("distances/v1/mapbox/${profile}", Method = WebRequestMethods.Http.Post)]
    public class MapboxDistanceRequest
        : MapboxRequest<MapboxDistanceResponse>
    {

        [RestUrlParameter("${profile}")]
        public string Profile { get; set; }

        [RestContent("content")]
        public MapboxDistanceRequestContent Content { get; set; }

        protected internal MapboxDistanceRequest() : base()
        {
            //Content = new MapboxDistanceRequestContent();
        }
    
    }
}
