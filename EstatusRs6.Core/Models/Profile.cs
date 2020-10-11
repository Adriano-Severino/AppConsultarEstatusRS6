using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstatusRs6.Core.Models
{
    public partial class Profile
    {
        [JsonProperty("p_id")]
        public Guid PId { get; set; }

        [JsonProperty("p_name")]
        public string PName { get; set; }

        [JsonProperty("p_user")]
        public Guid PUser { get; set; }

        [JsonProperty("p_platform")]
        public string PPlatform { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("information")]
        public string Information { get; set; }
    }

}
