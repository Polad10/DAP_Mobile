using Newtonsoft.Json;
using System;

namespace DAP_Mobile.Models
{
    public class Treatment
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime? EndDate { get; set; }

        [JsonProperty("diagnosis")]
        public string Diagnosis { get; set; }

        [JsonProperty("extra_info")]
        public string ExtraInfo { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("patient")]
        public Patient Patient { get; set; }
    }
}
