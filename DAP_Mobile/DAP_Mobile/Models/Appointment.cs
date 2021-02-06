using System;
using System.Runtime.Serialization;
using Xamarin.Forms.Internals;

namespace DAP_Mobile.Models
{
    /// <summary>
    /// Model for the Daily timeline and Company history page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    public class Appointment
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "date")]
        public DateTime Date { get; set; }

        [DataMember(Name = "time")]
        public DateTime Time { get; set; }

        [DataMember(Name = "icon")]
        public string Icon { get; set; }

        [DataMember(Name = "actions")]
        public string Actions { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "treatment")]
        public Treatment Treatment { get; set; }
    }
}
