using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Xamarin.Forms.Internals;

namespace DAP_Mobile.Models
{
    [Preserve(AllMembers = true)]
    [DataContract]
    public class Payment
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "amount")]
        public Decimal Amount { get; set; }

        [DataMember(Name = "date")]
        public DateTime Date { get; set; }

        [DataMember(Name = "time")]
        public DateTime Time { get; set; }

        [DataMember(Name = "patient")]
        public Patient Patient { get; set; }

        [DataMember(Name = "treatment")]
        public Treatment Treatment { get; set; }
    }
}
