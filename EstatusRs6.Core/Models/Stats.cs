using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstatusRs6.Core.Models
{
    public partial class Stats
    {
        [JsonProperty("level")]
        public long Level { get; set; }
    }
}
