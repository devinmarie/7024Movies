using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace _7024Movies.Models
{ 
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class ThrillerMovies
    {
       public int ThrillerId { get; set; }

        public partial class MovieIds
        {
            public static object movies { get; internal set; }
            [JsonProperty("id")]
            public long Id { get; set; }


        }
    }
}
