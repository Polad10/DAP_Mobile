using Newtonsoft.Json;
using System;

namespace DAP_Mobile.Models
{
    public class Product
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("price")]
        public Decimal Price { get; set; }

        [JsonProperty("treatment")]
        public Treatment Treatment { get; set; }
    }
}
