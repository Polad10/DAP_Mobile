using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Xamarin.Forms.Internals;

namespace DAP_Mobile.Models
{
    [Preserve(AllMembers = true)]
    [DataContract]
    class Patient
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string ExtraInfo { get; set; }

        [DataMember]
        public DateTime Dob { get; set; }

        [DataMember]
        public string PhoneNr { get; set; }
    }
}
