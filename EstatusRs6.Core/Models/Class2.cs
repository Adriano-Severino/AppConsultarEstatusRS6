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

//        [JsonProperty("region")]
//        public string Region { get; set; }

//        [JsonProperty("platform")]
//        public string Platform { get; set; }

//        [JsonProperty("regtext")]
//        public string Regtext { get; set; }

//        [JsonProperty("plattext")]
//        public string Plattext { get; set; }

//        [JsonProperty("players")]
//        public Dictionary<string, Player> Players { get; set; }

//        [JsonProperty("test")]
//        public Guid[] Test { get; set; }
//    }

//    public partial class Player
//    {
//        [JsonProperty("ranked")]
//        public Dictionary<string, double> Ranked { get; set; }

//        [JsonProperty("stats")]
//        public Stats Stats { get; set; }

//        [JsonProperty("profile")]
//        public Profile Profile { get; set; }
//    }

//    public partial class Profile
//    {
//        [JsonProperty("verified")]
//        public long Verified { get; set; }

//        [JsonProperty("p_name")]
//        public string PName { get; set; }

//        [JsonProperty("p_user")]
//        public Guid PUser { get; set; }

//        [JsonProperty("p_platform")]
//        public PPlatform PPlatform { get; set; }
//    }

//    public partial class Stats
//    {
//        [JsonProperty("level")]
//        public long Level { get; set; }
//    }

//    public enum PPlatform { Uplay };

//    internal static class Converter
//    {
//        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
//        {
//            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
//            DateParseHandling = DateParseHandling.None,
//            Converters =
//            {
//                PPlatformConverter.Singleton,
//                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
//            },
//        };
//    }

//    internal class PPlatformConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(PPlatform) || t == typeof(PPlatform?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            if (value == "uplay")
//            {
//                return PPlatform.Uplay;
//            }
//            throw new Exception("Cannot unmarshal type PPlatform");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (PPlatform)untypedValue;
//            if (value == PPlatform.Uplay)
//            {
//                serializer.Serialize(writer, "uplay");
//                return;
//            }
//            throw new Exception("Cannot marshal type PPlatform");
//        }

//        public static readonly PPlatformConverter Singleton = new PPlatformConverter();
//    }
//}
