using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieId
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class MovieIds
    {
        public static object movies { get; internal set; }
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("imdb_id")]
        public string ImdbId { get; set; }

        [JsonProperty("facebook_id")]
        public object FacebookId { get; set; }

        [JsonProperty("instagram_id")]
        public string InstagramId { get; set; }

        [JsonProperty("twitter_id")]
        public string TwitterId { get; set; }
    }

    public partial class MovieIds
    {
        public static MovieIds FromJson(string json) => JsonConvert.DeserializeObject<MovieIds>(json, MovieId.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this MovieIds self) => JsonConvert.SerializeObject(self, MovieId.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}

