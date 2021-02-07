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
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public Decimal Amount { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public DateTime Time { get; set; }

        [DataMember]
        public Patient Patient { get; set; }

        [DataMember]
        public Treatment Treatment { get; set; }
    }
}
