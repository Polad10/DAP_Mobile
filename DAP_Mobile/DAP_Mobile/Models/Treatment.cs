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
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "start_date")]
        public DateTime StartDate { get; set; }

        [DataMember(Name = "end_date")]
        public DateTime EndDate { get; set; }

        [DataMember(Name = "diagnosis")]
        public string Diagnosis { get; set; }

        [DataMember(Name = "extra_info")]
        public string ExtraInfo { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "patient")]
        public Patient Patient { get; set; }
    }
}
