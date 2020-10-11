using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstatusRs6.Core.Models
{
    public partial class Players
    {
        [JsonProperty("profile")]
        public Profile Profile { get; set; }

        [JsonProperty("refresh")]
        public Refresh Refresh { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("ranked")]
        public Dictionary<string, double> Ranked { get; set; }
    }

}
