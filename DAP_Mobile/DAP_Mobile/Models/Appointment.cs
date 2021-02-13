using Newtonsoft.Json;
using System;

namespace DAP_Mobile.Models
{
    public class Appointment
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("time")]
        public DateTime Time { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("actions")]
        public string Actions { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("treatment")]
        public Treatment Treatment { get; set; }
    }
}
