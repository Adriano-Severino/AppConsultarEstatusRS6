using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstatusRs6.Core.Models
{
    public partial class Refresh
    {
        [JsonProperty("x")]
        public long X { get; set; }

        [JsonProperty("s")]
        public long S { get; set; }
    }
}
