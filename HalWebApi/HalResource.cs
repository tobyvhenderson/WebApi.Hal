﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace HalWebApi
{
    public abstract class HalResource
    {
        protected HalResource()
        {
            Links = new List<Link>();
        }

        [JsonIgnore]
        public string Rel { get; set; }

        [JsonIgnore]
        public string Href { get; set; }

        [JsonIgnore]
        public string LinkName { get; set; }

        [JsonProperty("_links")]
        public List<Link> Links { get; set; }
    }
}