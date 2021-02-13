using Newtonsoft.Json;
using System;

namespace DAP_Mobile.Models
{
    public class Payment
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("amount")]
        public Decimal Amount { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("time")]
        public DateTime Time { get; set; }

        [JsonProperty("patient")]
        public Patient Patient { get; set; }

        [JsonProperty("treatment")]
        public Treatment Treatment { get; set; }
    }
}
