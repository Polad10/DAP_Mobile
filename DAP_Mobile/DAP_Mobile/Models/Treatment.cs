using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using Xamarin.Forms.Internals;

namespace DAP_Mobile.Models
{
    [Preserve(AllMembers = true)]
    [DataContract]
    public class Treatment
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime StartDate { get; set; }

        [DataMember]
        public DateTime EndDate { get; set; }

        [DataMember]
        public string Diagnosis { get; set; }

        [DataMember]
        public string ExtraInfo { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public Patient Patient { get; set; }
    }
}
