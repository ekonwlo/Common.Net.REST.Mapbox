using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Mapbox.v5.Geocode
{
    public enum GeocodePlaceTypes : int
    {
        Country = 1,	    // Sovereign states and other political entities. Examples: United States, France, China, Russia.
        Region = 2,         // First order administrative divisions within a country, usually provinces or states. Examples: California, Ontario, Essonne.
        Postcode = 4,       // Postal code, varies by a country's postal system. Examples: 20009, CR0 3RL.
        Place = 8,          // City, town, village or other municipality relevant to a country's address or postal system. Examples: Cleveland, Saratoga Springs, Berlin, Paris.
        Neighborhood= 16,   // A common name for a subarea of a populated place, often named by convention and without official or fixed boundaries. Examples: Montparnasse, Haight-Ashbury, Downtown.
        Address = 32,       // A street address with house number. Examples: 1600 Pennsylvania Ave NW, 1051 Market St, Oberbaumstrasse 7.
        POI = 64 	        // Places of interest including commercial venues, major landmarks, parks, and other features. Examples: Yosemite National Park, Lake Superior.

    }
}
