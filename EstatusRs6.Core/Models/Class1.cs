//namespace EstatusRs6.Core.Models
//{
//    using System;
//    using System.Collections.Generic;

//    using System.Globalization;
//    using Newtonsoft.Json;
//    using Newtonsoft.Json.Converters;

//    public partial class RootObject
//    {
//        [JsonProperty("status")]
//        public long Status { get; set; }

//        [JsonProperty("foundmatch")]
//        public bool Foundmatch { get; set; }

//        [JsonProperty("requested")]
//        public string Requested { get; set; }

//        [JsonProperty("players")]
//        public Dictionary<string, Players> players { get; set; }
//    }

  

//    public partial class Players
//    {
//        [JsonProperty("profile")]
//        public Profile Profile { get; set; }

//        [JsonProperty("refresh")]
//        public Refresh Refresh { get; set; }

//        [JsonProperty("stats")]
//        public Stats Stats { get; set; }

//        [JsonProperty("ranked")]
//        public Dictionary<string, double> Ranked { get; set; }
//    }

//    public partial class Profile
//    {
//        [JsonProperty("p_id")]
//        public Guid PId { get; set; }

//        [JsonProperty("p_name")]
//        public string PName { get; set; }

//        [JsonProperty("p_user")]
//        public Guid PUser { get; set; }

//        [JsonProperty("p_platform")]
//        public string PPlatform { get; set; }

//        [JsonProperty("verified")]
//        public bool Verified { get; set; }

//        [JsonProperty("information")]
//        public string Information { get; set; }
//    }

//    public partial class Refresh
//    {
//        [JsonProperty("x")]
//        public long X { get; set; }

//        [JsonProperty("s")]
//        public long S { get; set; }
//    }

//    public partial class Stats
//    {
//        [JsonProperty("level")]
//        public long Level { get; set; }
//    }
//}
