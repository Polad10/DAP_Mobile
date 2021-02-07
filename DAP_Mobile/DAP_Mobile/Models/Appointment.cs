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
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public DateTime Time { get; set; }

        [DataMember]
        public string Icon { get; set; }

        [DataMember]
        public string Actions { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public Treatment Treatment { get; set; }
    }
}
