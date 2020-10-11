using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstatusRs6.Core.Models
{
    public class Root
    {
        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("foundmatch")]
        public bool Foundmatch { get; set; }

        [JsonProperty("requested")]
        public string Requested { get; set; }

        [JsonProperty("players")]
        public Dictionary<string, Players> players { get; set; }
    }
}