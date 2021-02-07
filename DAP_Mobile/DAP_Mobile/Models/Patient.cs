using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Xamarin.Forms.Internals;

namespace DAP_Mobile.Models
{
    [Preserve(AllMembers = true)]
    [DataContract]
    public class Patient
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "first_name")]
        public string FirstName { get; set; }

        [DataMember(Name = "last_name")]
        public string LastName { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "extra_info")]
        public string ExtraInfo { get; set; }

        [DataMember(Name = "dob")]
        public DateTime Dob { get; set; }

        [DataMember(Name = "phone_nr")]
        public string PhoneNr { get; set; }
    }
}
